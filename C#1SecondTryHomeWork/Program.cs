using System.Text;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            // РУНЫ
            var fireT1 = new Rune { Element = "Огонь", Tier = 1, PowerBonus = 10 };
            var fireT2 = new Rune { Element = "Огонь", Tier = 2, PowerBonus = 25 };
            var iceT1 = new Rune { Element = "Лед", Tier = 1, PowerBonus = 10 };

            // ОРУЖИЕ
            var dagger = new Weapon { Id = 1, Name = "Кинжал", BaseDamage = 20, Weight = 0.8f };
            dagger.SocketRune(fireT1);

            var axe = new Weapon { Id = 2, Name = "Двуручный Топор", BaseDamage = 70, Weight = 9.5f };

            var paladinSword = new Weapon { Id = 3, Name = "Меч Паладина", BaseDamage = 45, Weight = 3.2f };
            paladinSword.SocketRune(fireT2);
            paladinSword.SocketRune(iceT1);

            var shadowBow = new Weapon { Id = 4, Name = "Лук Теней", BaseDamage = 50, Weight = 1.5f };
            shadowBow.SocketRune(fireT1);

            // ИНВЕНТАРЬ
            var inventory = new HeroInventory();
            inventory.AddWeapon(dagger);
            inventory.AddWeapon(axe);
            inventory.AddWeapon(paladinSword);
            inventory.AddWeapon(shadowBow);

            // Проверка IEquatable
            var search = new Weapon { Id = 1 };
            Console.WriteLine("Есть ли кинжал? " + inventory.HasWeapon(search));

            // Сортировка по умолчанию
            inventory.SortByDefault();
            inventory.PrintAll("Сортировка по урону (IComparable)");

            // Сортировка по весу
            inventory.Sort(new WeaponWeightComparer(SortOrder.Ascending));
            inventory.PrintAll("Сортировка по весу (Ascending)");

            // Сортировка по количеству рун
            inventory.Sort(new WeaponRuneCountComparer(SortOrder.Descending));
            inventory.PrintAll("Сортировка по количеству рун (Descending)");


        }
    }
}