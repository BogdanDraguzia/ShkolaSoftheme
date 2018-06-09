namespace HW8_2
{
    struct Car
    {
        public Engine Engine { set; get; }
        public  Color Color { set; get; }
        public Transmission Transmission { set; get; }

        public Car(Engine e, Color c, Transmission t)
        {
            Engine = e;
            Color = c;
            Transmission = t;
        }
    }
}
