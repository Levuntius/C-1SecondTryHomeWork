using System.Text;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            MyStack stack = new MyStack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Сейчас сверху: " + stack.Peek());

            Console.WriteLine("Pop: " + stack.Pop());
            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine("Сейчас сверху: " + stack.Peek());

            stack.Clear();

            Console.WriteLine("После очистки Count = " + stack.GetCount());

            Console.WriteLine("Pop: " + stack.Pop());

            Console.ReadLine();


        }
    }
}