using System.Text;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            MyQueue queue = new MyQueue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine($"Первый в очереди: {queue.Peek()}"); 

            Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");

            Console.WriteLine($"Первый в очереди: {queue.Peek()}");

            queue.Clear();

            Console.WriteLine($"После очистки Count = {queue.GetCount()}");
            Console.ReadLine();



        }
    }
}