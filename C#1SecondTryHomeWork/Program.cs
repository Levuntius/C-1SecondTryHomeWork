namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Creature archer = new Archer("Эльф");
            Creature swordsman = new Swordsman("Орк");
            Creature screamer = new Screamer("Крикун");

            archer.Emotion = "улыбаюсь";
            archer.Movement = "иду";

            swordsman.Emotion = "злюсь";
            swordsman.Movement = "бегу";

            screamer.Emotion = "покерфейс";
            screamer.Movement = "стою";

            archer.ShowState();
            archer.Attack();

            swordsman.ShowState();
            swordsman.Attack();

            screamer.ShowState();
            screamer.Attack();
        }
    }


}