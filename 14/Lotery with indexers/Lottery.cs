using System;

namespace Lotery_with_indexers
{
    internal class Lottery
    {
        private readonly int[] _numbers = new int[6];
        private readonly int[] _input = new int[6];

        private void Reinitialize()
        {
            var r = new Random();
            for (var i = 0; i < 6; i++) _numbers[i] = r.Next(1, 9);
        }

        public int this[int index] => _numbers[index];

        public void StartGame()
        {
            Reinitialize();

            Console.Clear();
            Console.Write("Input 6 numbers between 1 and 9:\n");

            for (var i = 0; i < 6; i++)
            {
                var c = Console.ReadKey().KeyChar;
                Console.Write(" ");

                if (!char.IsDigit(c) || c == '0')
                {
                    Console.Clear();
                    Console.Write("Bad input, try again:\n");
                    var s = "";
                    for (var j = 0; j < i; j++) s += string.Format("{0} ", _input[j]);
                    Console.Write(s);
                    i--;
                    continue;
                }

                _input[i] = int.Parse(c.ToString());
            }

            PrintInput();
            PrintWinningCombination();
            Console.WriteLine("You gained {0} points", Check());
            Console.WriteLine("Press Enter to start a new game or any other key to exit ");
            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
                StartGame();
            else
                Environment.Exit(0);
        }

        private void PrintWinningCombination()
        {
            var res = string.Empty;
            for (var i = 0; i < 6; i++) res += string.Format("{0} ", _numbers[i]);
            Console.Write("\nWinning Combination: \n" + res);
        }

        public void PrintInput()
        {
            var res = string.Empty;
            for (var i = 0; i < 6; i++) res += string.Format("{0} ", _input[i]);
            Console.Write("\nYour input: \n" + res);
        }

        public int Check()
        {
            var points = 0;
            for (var i = 0; i < 6; i++)
                if (_numbers[i] == _input[i])
                    points++;
            return points;
        }
    }
}