using System;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Создаём счёт через конструктор №2
            BankAccount acc = new BankAccount("12345", "Лев Гладышев", 5000);

            Console.WriteLine(acc.GetInfo());
            Console.WriteLine();

            // Пополнение
            acc.Deposit(1500);
            Console.WriteLine("После пополнения:");
            Console.WriteLine(acc.GetInfo());
            Console.WriteLine();

            // Снятие
            if (!acc.Withdraw(8000, out string error))
            {
                Console.WriteLine("Ошибка: " + error);
            }
            else
            {
                Console.WriteLine("Снятие успешно.");
            }

            Console.WriteLine();
            Console.WriteLine("Текущее состояние счёта:");
            Console.WriteLine(acc.GetInfo());
        }
    }
}

