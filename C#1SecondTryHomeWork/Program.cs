namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                double result;
                Console.WriteLine("Введите первое число");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите операцию (+, -, *, /)");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "-":
                        result = a - b;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "*":
                        result = a * b;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    case "/":
                        if (b == 0)
                            throw new DivideByZeroException();

                        result = a / b;
                        Console.WriteLine($"Результат: {result}");
                        break;

                    default:
                        Console.WriteLine("Такой операции нет");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }

        }
    }
}
