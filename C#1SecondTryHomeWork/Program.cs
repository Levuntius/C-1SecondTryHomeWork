using System.Text;

namespace C_1SecondTryHomeWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;                 
            
            var bow1 = new GameItem(1, "Лук охотника", 5);
            var bow2 = new GameItem(1, "Лук охотника", 5);

            var inventory = new Inventory();

            inventory.AddItem(bow1, 3);
            inventory.AddItem(bow2, 4); // те же ID вывод будет 7

            inventory.RemoveItem(bow1, 5);

            inventory.AddItem(bow1, 2);
            inventory.AddItem(new GameItem(2, "Зелье здоровья", 10), 7);

            Console.WriteLine("\nИнвентарь:");
            for (int i = 0; i < inventory.Count; i++)
            {
                var pair = inventory[i];
                Console.WriteLine($"{pair.Key.Name}: {pair.Value}");
            }

            var quests = new QuestLog();
            quests.CompleteQuest(10);
            quests.CompleteQuest(10);
        }
    }


}