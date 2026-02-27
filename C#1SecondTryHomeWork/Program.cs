using static System.Runtime.InteropServices.JavaScript.JSType;



using System;
using System.Text;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            double balance = 2612;
            int choice;
            string history = "";

            while (true)
            {
                ShowMenu();
                choice = GetMenuChoice();

                switch (choice)
                {
                    case 1:
                        ShowBalance(balance);
                        break;

                    case 2:
                        double topUpAmount = GetAmount("пополнения");
                        balance = AddMoney(balance, topUpAmount, history);
                        break;

                    case 3:
                        double withdrawAmount = GetAmount("снятия");
                        balance = WithdrawMoney(balance, withdrawAmount, history);
                        break;

                    case 4:
                        ShowHistory(history);
                        break;
                }
            }
        }

        // Показывает меню
        static void ShowMenu()
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Проверить баланс");
            Console.WriteLine("2. Пополнить счёт");
            Console.WriteLine("3. Снять деньги");
            Console.WriteLine("4. История операций");
        }

        // Получает корректный выбор пользователя
        static int GetMenuChoice()
        {
            Console.Write("Введите число (1-4): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 4)
                return choice;

            Console.WriteLine("Ошибка! Введите число от 1 до 4.");
            return 0;
        }

        // Показывает баланс
        static void ShowBalance(double balance)
        {
            Console.WriteLine($"Ваш баланс: {balance}");
        }

        // Получает сумму
        static double GetAmount(string operationName)
        {
            Console.Write($"Введите сумму для {operationName}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double amount) && amount > 0)
                return amount;

            Console.WriteLine("Ошибка! Введите положительное число.");
            return 0;
        }

        // Пополнение
        static double AddMoney(double balance, double amount, string history)
        {
            if (amount <= 0) return balance;

            balance += amount;
            history += $"Пополнение: +{amount} | Баланс: {balance}\n";

            Console.WriteLine($"Баланс успешно пополнен: {balance}");
            return balance;
        }

        // Снятие
        static double WithdrawMoney(double balance, double amount, string history)
        {
            if (amount <= 0) return balance;

            if (amount > balance)
            {
                Console.WriteLine("Ошибка! Недостаточно средств.");
                return balance;
            }

            balance -= amount;
            history += $"Снятие: -{amount} | Баланс: {balance}\n";

            Console.WriteLine($"Снятие выполнено: {balance}");
            return balance;
        }

        // История
        static void ShowHistory(string history)
        {
            if (string.IsNullOrEmpty(history))
            {
                Console.WriteLine("История операций пуста.");
                return;
            }

            Console.WriteLine("История операций:");
            Console.WriteLine(history);
        }
    }
}