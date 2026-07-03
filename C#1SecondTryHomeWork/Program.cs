using System;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount account = new BankAccount("123456789012", "Лев Гладышев", 5000);
            var info = account.GetInfo();
            Console.WriteLine("Информация о счёте");
            Console.WriteLine($"Номер: {info.accountNumber}");
            Console.WriteLine($"Владелец: {info.ownerName}");
            Console.WriteLine($"Баланс: {info.balance} грн");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Пожалуйста, выберите операцию");
                Console.WriteLine("1 Пополнить счёт");
                Console.WriteLine("2 Снять деньги со счёта");
                Console.WriteLine("3 Вывести информацию о счёте");
                Console.WriteLine("Введите цифру 1–3");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите сумму пополнения ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depAmount))
                        {
                            try
                            {
                                decimal oldBalance = account.Balance;
                                account.Deposit(depAmount);
                                Console.WriteLine($"Баланс был: {oldBalance} грн");
                                Console.WriteLine($"Баланс стал: {account.Balance} грн");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма");
                        }
                        break;

                    case "2":
                        Console.Write("Введите сумму снятия");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            decimal oldBalance = account.Balance;

                            if (!account.Withdraw(withdrawAmount, out string error))
                            {
                                Console.WriteLine("Ошибка: " + error);
                            }
                            else
                            {
                                Console.WriteLine($"Баланс был: {oldBalance} грн");
                                Console.WriteLine($"Баланс стал: {account.Balance} грн");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма");
                        }
                        break;

                    case "3":
                        var info = account.GetInfo();
                        Console.WriteLine("Информация о счёте");
                        Console.WriteLine($"Номер: {info.accountNumber}");
                        Console.WriteLine($"Владелец: {info.ownerName}");
                        Console.WriteLine($"Баланс: {info.balance} грн");
                        break;

                    default:
                        Console.WriteLine("Операция не распознана");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Чтобы продолжить, снова выберите операцию (1–3)");
                Console.WriteLine();
            }
        }
    }
}
