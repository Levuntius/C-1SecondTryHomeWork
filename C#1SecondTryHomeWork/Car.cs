namespace C_1SecondTryHomeWork
{
    enum Color
    {
        Red,
        Blue,
        Black,
        White,
        Green
    }

    class Car
    {
        private string _make;
        private string _model;
        private Color _color;

        public string Make
        {
            get {return _make;}
            set {_make = value;}
        }

        public string Model
        {
            get {return _model;}
            set {_model = value;}
        }


        public Color Color
        {
            get {return _color;}
            set {_color = value;}
        }

        public Car(string make, string model, Color color)
        {
            _make = make;
            _model = model;
            _color = color;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Информация об автомобиле");
            Console.WriteLine("Марка: " + _make);
            Console.WriteLine("Модель: " + _model);
            Console.WriteLine("Цвет: " + _color);
        }
    }
}
