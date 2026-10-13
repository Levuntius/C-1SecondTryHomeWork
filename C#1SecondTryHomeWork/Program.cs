namespace C_1SecondTryHomeWork
{
    class Program
    {
        static void Main()
        {
            var products = new ProductCollection();
            products.Add("Milk");
            products.Add("Bread");
            products.Add("Cheese");

            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }
    }

}