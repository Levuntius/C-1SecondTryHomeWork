using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            double balance = 2612;
            int choice;
            List<string> history = new List<string>();

            while (true)
            {
                ShowWelcome();

                Console.Write("Введите число (1-4): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Ошибка! Введите число от 1 до 4.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CheckBalance(balance);
                        break;

                    case 2:
                        balance = TopUpYourBalance(balance, history);
                        break;

                    case 3:
                        balance = WithdrawMoneyFromTheBalance(balance, history);
                        break;

                    case 4:
                        ShowHistory(history);
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void ShowWelcome()
        {
            Console.WriteLine("Здравствуйте! Выберите операцию:");
            Console.WriteLine("1. Проверить баланс");
            Console.WriteLine("2. Пополнить счёт");
            Console.WriteLine("3. Снять деньги");
            Console.WriteLine("4. Посмотреть историю операций");
            Console.WriteLine();
        }

        static void CheckBalance(double balance)
        {
            Console.WriteLine("Ваш баланс: " + balance);
        }

        static double TopUpYourBalance(double balance, List<string> history)
        {
            Console.Write("Введите сумму для пополнения: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double amount) && amount > 0)
            {
                balance += amount;

                string operation = $"{DateTime.Now} | Пополнение +{amount} | Баланс: {balance}";
                history.Add(operation);

                Console.WriteLine("Баланс успешно пополнен. Текущий баланс: " + balance);
            }
            else
            {
                Console.WriteLine("Ошибка! Введите положительное число.");
            }

            return balance;
        }

        static double WithdrawMoneyFromTheBalance(double balance, List<string> history)
        {
            Console.Write("Введите сумму для снятия: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double amount) && amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;

                    string operation = $"{DateTime.Now} | Снятие -{amount} | Баланс: {balance}";
                    history.Add(operation);

                    Console.WriteLine("Снятие успешно. Текущий баланс: " + balance);
                }
                else
                {
                    Console.WriteLine("Ошибка! Недостаточно средств.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите положительное число.");
            }

            return balance;
        }

        static void ShowHistory(List<string> history)
        {
            if (history.Count == 0)
            {
                Console.WriteLine("История операций пуста.");
                return;
            }

            Console.WriteLine("История операций:");
            Console.WriteLine();

            foreach (string item in history)
            {
                Console.WriteLine(item);
            }
        }
    }
}