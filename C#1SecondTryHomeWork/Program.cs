using C_1SecondTryHomeWork;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        var pirate = new Fighter("Пиратский корабль");

        var fighter = new Fighter("Истребитель Альфа");
        var turret = new DefenseTurret("Турель");
        turret.Enable();

        List<IAttacker> group = new() {fighter, turret};

        Console.WriteLine("Начало боя");

        for (int i = 0; i < group.Count; i++)
        {
            group[i].Attack(pirate);

            if (pirate.Hull <= 0)
            {
                Console.WriteLine("Цель уничтожена!");
                break;
            }
        }

        Console.WriteLine("Конец боя");
    }
}
