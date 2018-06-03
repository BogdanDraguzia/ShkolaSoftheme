using System;
using System.Windows;

namespace HW6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private byte _attempts =3;
        private byte _number;
        private byte _guessedNumber;

        public MainWindow()
        {
            InitializeComponent();
            Generate();
            
        }

        private void Generate()
        {
            _number = unchecked((byte)new Random().Next(0, 10));
            
            //This line
            MessageBox.Show("Generated number is " + _number.ToString());
            //could be commented to actually play:)
        }


        private void Restart()
        {
           Generate();
           _attempts = 3;
        }

        private bool CheckInput()
        {
            foreach (var s in NumberInput.Text)
                if (!char.IsDigit(s)) throw new MyException("Your input should be a number");

            if (NumberInput.Text == "") throw new MyException("Empty input");

            var tmp = byte.Parse(NumberInput.Text);
            if (tmp > 10) throw new MyException("Out of range [0,10]");

            return true;

        }

        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CheckInput())
                {   
                    _guessedNumber = byte.Parse(NumberInput.Text);
                    if (_guessedNumber == _number)
                    {
                        MessageBox.Show("Congraulations!, The correct number is" + _number);
                        Restart();
                        NumberInput.Text = "";
                    }
                    else
                    {
                        _attempts--;
                        if (_attempts == 0)
                        {
                            Restart();
                            MessageBox.Show("No, that's wrong. Restarting... " + _attempts + " attempts left");
                            NumberInput.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("No, that's wrong. Try again! " + _attempts + " attempts left");
                            NumberInput.Text = "";
                        }
                    }

                }
            }
            catch (MyException exception)
            {
                MessageBox.Show(exception.Message);
                NumberInput.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
