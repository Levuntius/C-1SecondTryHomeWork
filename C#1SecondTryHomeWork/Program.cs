namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            string password = "12345";
            int attempts = 5;

            try
            {

                while (attempts > 0)
                {
                    Console.Write("Введите пароль: ");
                    string input = Console.ReadLine();

                    if (input == password)
                    {
                        Console.WriteLine("Добро пожаловать");
                        return; // завершаем программу
                    }
                    else
                    {
                        attempts--;
                        if (attempts > 0)
                        {
                            Console.WriteLine($"Неверный пароль. Осталось попыток: {attempts}");
                        }
                        else
                        {
                            Console.WriteLine("Попытки закончились");
                        }
                    }
                }


            }

            catch (FormatException)
            {
                Console.WriteLine($"То что вы ввели не может быть паролем");
            }

        }

    }

}

