namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

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
