namespace HW7_2
{
    class Human
    {
        public int BirthDate { get; }
        public string FirstName { get; }
        public  string LastName { get; }
        public  int Age { get;}

        public Human() { }
        public Human(int birthDate, string firstName, string lastName, int age)
        {
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Human(int birthDate, string firstName, string lastName)
        {
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            Age = 2018 - birthDate;
        }

        public Human(Human origin)
        {
            Age = origin.Age;
            BirthDate = origin.BirthDate;
            FirstName = origin.FirstName;
            LastName = origin.LastName;
        }

        public static bool Equals(Human a, Human b)
        {
            return a.Age == b.Age && a.BirthDate == b.BirthDate && a.FirstName.Equals(b.FirstName) &&
                   a.LastName.Equals(b.LastName);
        }
    }
}
