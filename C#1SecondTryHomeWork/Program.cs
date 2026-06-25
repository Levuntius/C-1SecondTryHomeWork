namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

        }
    }

    

// Перечисление цветов автомобиля
enum Color
    {
        Red,
        Blue,
        Black,
        White,
        Green,
        Silver
    }

    // Класс автомобиля
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Color Color { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Информация об автомобиле:");
            Console.WriteLine($"Марка: {Make}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Цвет: {Color}");
        }
    }

    // Класс человека
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; } // рост в сантиметрах
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта Car
            Car car = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2022,
                Color = Color.Black
            };

            // Вывод информации об автомобиле
            car.ShowInfo();

            Console.WriteLine();

            // Создание объекта Person
            Person person = new Person
            {
                FirstName = "Лев",
                LastName = "Гладышев",
                Height = 180,
                Age = 25
            };

            Console.WriteLine("Информация о человеке:");
            Console.WriteLine($"Имя: {person.FirstName}");
            Console.WriteLine($"Фамилия: {person.LastName}");
            Console.WriteLine($"Рост: {person.Height} см");
            Console.WriteLine($"Возраст: {person.Age} лет");
        }
    }
}

