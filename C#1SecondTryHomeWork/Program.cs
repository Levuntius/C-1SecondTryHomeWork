namespace C_1SecondTryHomeWork
{
    using C_1SecondTryHomeWork.Enemy_types;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Бой начинается\n");

            // Создание монстров
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

            Creeper creeper1 = new Creeper("Крипер1");
            Creeper creeper2 = new Creeper("Крипер2");

            // Массив всех монстров
            Enemy[] monsters =
            {
                orc1, orc2,
                dragon1, dragon2,
                skeleton1, skeleton2,
                wolf1, wolf2,
                zombie1, zombie2,
                vampire1, vampire2,
                creeper1, creeper2,
            };

            Random rnd = new Random();

            Console.WriteLine("\n--- Цикл атак начинается ---\n");

            for (int i = 0; i < monsters.Length; i++)
            {
                Enemy attacker = monsters[i];

                // DOWNCAST
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
                else if (attacker is Creeper c)
                    Console.WriteLine($"(Downcast) {c.Name} — Крипер");

                // Выбираем случайного монстра, кроме самого себя
                int randomIndex = rnd.Next(monsters.Length - 1);

                if (randomIndex >= i)
                    randomIndex++;

                Enemy target = monsters[randomIndex];

                attacker.Attack(target);

                Console.WriteLine();
            }

            Console.WriteLine("Бой завершён");
        }
    }
}
