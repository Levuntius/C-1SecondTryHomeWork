namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int a;
            int b;

            Console.Write("Введите число a: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                    continue;
                }
            }

            Console.Write("Введите число b: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                    continue;
                }
            }

            int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 != 0)
                {
                   sum += i * i;
                }
            }
            Console.WriteLine($"Сумма квадратов нечётных чисел от {a} до {b} = {sum}");


        }   
     }

}
