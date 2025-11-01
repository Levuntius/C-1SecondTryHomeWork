namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            Console.Write("write the integer a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("write the integer b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("write the integer c: ");
            int c = int.Parse(Console.ReadLine());

            // Task a
          
            double taskA = a + b - (3.0 * a * b + a * a) / (b * c);

            Console.WriteLine($"Task a answer: {taskA}");
           
            // Task B
            
            double taskB = Math.Pow(a * b + 7 * c, 3) - (a * a + b * b + c * c) / b - a * c - a * (b + c);
            Console.WriteLine($"Task b answer: {taskB}");
           
         
        }
}
