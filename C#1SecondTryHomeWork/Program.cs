namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            int age;
            float height;
            char gender;
            char favorite_letter_of_the_alphabet;
            string city_​of_residence;

            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("Введите ваш возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);

            Console.WriteLine("Введите ваш рост в метрах");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine(height);

            Console.WriteLine("Введите ваш пол (М/Ж)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите вашу любимую букву алфавита");
            favorite_letter_of_the_alphabet = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите ваш город проживания");
            city_​of_residence = Console.ReadLine();


            Console.WriteLine("\t----- АНКЕТА ПОЛЬЗОВАТЕЛЯ -----");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Рост: {height} м");
            Console.WriteLine($"Пол: {gender}");
            Console.WriteLine($"Любимая буква: {favorite_letter_of_the_alphabet}");
            Console.WriteLine($"Город: {city_​of_residence}");

        }
    }
}
