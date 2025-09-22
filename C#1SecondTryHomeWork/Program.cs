namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
           
            string name;
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();

            int age;
            Console.WriteLine("Введите ваш возраст");
            age = int.Parse(Console.ReadLine());

            float height;
            Console.WriteLine("Введите ваш рост в метрах");
            height = float.Parse(Console.ReadLine());

            char gender;
            Console.WriteLine("Введите ваш пол (М/Ж)");
            gender = char.Parse(Console.ReadLine());

            char favoriteLetterOfTheAlphabet;

            Console.WriteLine("Введите вашу любимую букву алфавита");
            favoriteLetterOfTheAlphabet = char.Parse(Console.ReadLine());

            string cityOfResidence;
            Console.WriteLine("Введите ваш город проживания");
            cityOfResidence = Console.ReadLine();


            Console.WriteLine("\t----- АНКЕТА ПОЛЬЗОВАТЕЛЯ -----");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age} лет");
            Console.WriteLine($"Рост: {height} м");
            Console.WriteLine($"Пол: {gender}");
            Console.WriteLine($"Любимая буква: {favoriteLetterOfTheAlphabet}");
            Console.WriteLine($"Город: {cityOfResidence}");

        }
    }
}
