namespace C_1SecondTryHomeWork;

using C_1SecondTryHomeWork.Properties.Enemy_types;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Бой начинается\n");

        // Создаём монстров
        Orc orc1 = new Orc("Орк1");
        Orc orc2 = new Orc("Орк2");

        Dragon dragon1 = new Dragon("Дракон1");
        Dragon dragon2 = new Dragon("Дракон2");

        Skeleton skeleton1 = new Skeleton("Скелет1");
        Skeleton skeleton2 = new Skeleton("Скелет2");

        Werewolf wolf1 = new Werewolf("Оборотень1");
        Werewolf wolf2 = new Werewolf("Оборотень2");

        Zombie zombie1 = new Zombie("Зомби1");
        Zombie zombie2 = new Zombie("Зомби2");

        Vampire vampire1 = new Vampire("Вампир1");
        Vampire vampire2 = new Vampire("Вампир2");

        // Массив всех монстров
        Enemy[] monsters =
        {
            orc1, orc2,
            dragon1, dragon2,
            skeleton1, skeleton2,
            wolf1, wolf2,
            zombie1, zombie2,
            vampire1, vampire2
        };

        Random rnd = new Random();

        Console.WriteLine("\n--- Цикл атак начинается ---\n");

        foreach (Enemy attacker in monsters)
        {
            if (attacker is Dragon d)
                Console.WriteLine($"(Downcast) {d.Name} — Дракон");
            else if (attacker is Orc o)
                Console.WriteLine($"(Downcast) {o.Name} — Орк");
            else if (attacker is Skeleton s)
                Console.WriteLine($"(Downcast) {s.Name} — Скелет");
            else if (attacker is Werewolf w)
                Console.WriteLine($"(Downcast) {w.Name} — Оборотень");
            else if (attacker is Zombie z)
                Console.WriteLine($"(Downcast) {z.Name} — Зомби");
            else if (attacker is Vampire v)
                Console.WriteLine($"(Downcast) {v.Name} — Вампир");

            Enemy target = monsters[rnd.Next(monsters.Length)];

            attacker.Attack(target);

            Console.WriteLine();
        }

        Console.WriteLine("Бой завершён");
    }
}
