namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
            Console.WriteLine(name);

            int age;
            Console.WriteLine("Введите ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

        }
    }
}
