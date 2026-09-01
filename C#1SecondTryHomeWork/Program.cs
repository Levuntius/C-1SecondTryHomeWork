using C_1SecondTryHomeWork;

class Program
{
    static void Main()
    {
        var pirate = new Fighter("Пиратский корабль");

        var fighter = new Fighter("Истребитель Альфа");
        var turret = new DefenseTurret("Турель Т-1");
        turret.Enable();

        List<IAttacker> group = new() { fighter, turret };

        Console.WriteLine("=== Начало боя ===");

        for (int i = 0; i < group.Count; i++)
        {
            IAttacker attacker = group[i];
            attacker.Attack(pirate);

            if (pirate.Hull <= 0)
            {
                Console.WriteLine("Цель уничтожена!");
                break;
            }
        }

        Console.WriteLine("=== Бой завершён ===");
    }
}
