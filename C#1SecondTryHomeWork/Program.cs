namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // data entry
            Console.Write("write the integer a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("write the integer b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("write the integer c: ");
            int c = int.Parse(Console.ReadLine());

            // Task a
          
            double taskA = a + b - c * (3.0 * a * b + a * a) / (b * c) - Math.Pow(c + a * b / (double)c, 2);

            Console.WriteLine($"Task a answer: {taskA}");
           
            // Task B
            
            double taskB = (Math.Pow(a * b + 7 * c, 3) - (a * a + b * b + c * c)) / (b - a * c - a * (b + c));
            Console.WriteLine($"Task b answer: {taskB}");

           /*write the integer a: 0
             write the integer b: 1
             write the integer c: 1
             Task a answer: 1
             Task b answer: 341*/
        }
}   }
