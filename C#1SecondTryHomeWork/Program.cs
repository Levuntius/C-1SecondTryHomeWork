namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Dragon dragon1 = new Dragon("Дракон1");
            Dragon dragon2 = new Dragon("Дракон2");

            Orc orc1 = new Orc("Орк1");
            Skeleton skeleton1 = new Skeleton("Скелет1");

            Console.WriteLine("Бой начинается\n");

            orc1.Attack(dragon1);
            Console.WriteLine();

            skeleton1.Attack(orc1);
            Console.WriteLine();

            dragon2.Attack(skeleton1);
            Console.WriteLine();

            Console.WriteLine("Бой завершён");


        }
    }
}