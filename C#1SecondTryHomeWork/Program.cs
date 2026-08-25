using System.Text;

namespace C_1SecondTryHomeWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            var creature1 = new Creature(
                "Эльф",
                new BowAttack(),
                new Walk(),
                new Smile()
            );

            var creature2 = new Creature(
                "Орк",
                new SwordAttack(),
                new Run(),
                new Angry()
            );

            var creature3 = new Creature(
                "Крикун",
                new ScreamAttack(),
                new Stand(),
                new PokerFace()
            );

            creature1.ShowState();
            creature2.ShowState();
            creature3.ShowState();
        }
    }
