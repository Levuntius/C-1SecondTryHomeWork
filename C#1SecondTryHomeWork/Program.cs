namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

        }
    }

    

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
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Color Color { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Информация об автомобиле");
            Console.WriteLine($"Марка: {Make}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Цвет: {Color}");
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car
            {
                Make = "BMW",
                Model = "Tesla",
                Year = 2022,
                Color = Color.Black
            };

            car.ShowInfo();

            Console.WriteLine();

            Person person = new Person
            {
                FirstName = "Лев",
                LastName = "Гладышев",
                Height = 180,
                Age = 18
            };

            Console.WriteLine("Информация о человеке");
            Console.WriteLine($"Имя: {person.FirstName}");
            Console.WriteLine($"Фамилия: {person.LastName}");
            Console.WriteLine($"Рост: {person.Height} см");
            Console.WriteLine($"Возраст: {person.Age} лет");
        }
    }
}

