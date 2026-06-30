namespace C_1SecondTryHomeWork
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private double _height;
        private int _age;

        public string FirstName
        {
            get {return _firstName;}
            set {_firstName = value;}
        }

        public string LastName
        {
            get {return _lastName;}
            set {_lastName = value;}
        }

        public double Height
        {
            get {return _height;}
            set
            {
                if (value > 300)
                {
                    Console.WriteLine("Рост должен быть меньше 300 сантиметров");
                    return;
                }

                _height = value;
            }
        }


        public int Age
        {
            get {return _age;}
            set
            {
                if (value > 120)
                {
                    Console.WriteLine("Возраст должен быть меньше 120");
                    return;
                }

                _age = value;
            }
        }

        public Person(string firstName, string lastName, double height, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _height = height;
            _age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Информация о человеке");
            Console.WriteLine("Имя: " + _firstName);
            Console.WriteLine("Фамилия: " + _lastName);
            Console.WriteLine("Рост: " + _height + " см");
            Console.WriteLine("Возраст: " + _age + " лет");
        }
    }
}
