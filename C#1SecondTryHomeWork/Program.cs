using System;   

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Car car = new Car("BMW", "X5", 2022, Color.Black);
            car.ShowInfo();

            Console.WriteLine();

            Person person = new Person("Лев", "Гладышев", 180, 18);
            person.ShowInfo();
        }
    }
}
