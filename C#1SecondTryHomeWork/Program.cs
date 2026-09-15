namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var a = new Item { Id = 1, Name = "Sword" };
            var b = new Item { Id = 2, Name = "Shield" };

            Console.WriteLine($"A Hash = {a.GetHashCode()}");
            Console.WriteLine($"B Hash = {b.GetHashCode()}");

            Console.WriteLine("Equals: " + a.Equals(b));
            


        }
    }
}