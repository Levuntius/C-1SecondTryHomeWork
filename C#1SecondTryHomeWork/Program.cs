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
            int number;

            ShowWelcome();

            while (true)
            {
                Console.Write("Введите число (1-4): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number >= 1 && number <= 4)
                {
                    Console.WriteLine("Вы выбрали: " + number);
                    break; // выход из цикла
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число от 1 до 4.");
                }

                switch (number)
                {
                    case 1:
                        checkBalance(balance);
                        break;
                    case 2:
                        topUpYourBalance();
                        break;
                    case 3:
                        withdrawalOfMoney();
                        break;
                    case 4:
                        viewTransactionHistory();
                        break;
                }

            static void ShowWelcome()
            {
                Console.WriteLine("Здравствуйте напишите цифру для выбора операции");
                Console.WriteLine("1. Проверить баланс");
                Console.WriteLine("2. Пополнить счёт");
                Console.WriteLine("3. Снять деньги");
                Console.WriteLine("4. Посмотреть историю операций");
            }

            static void checkBalance(int: balance) 
            {
                Console.WriteLine("Ваш баланс: " + balance);
            }

        }
    }
}
