namespace C_1SecondTryHomeWork
{
    public class HeroInventory
    {
        private List<Weapon> _items = new();

        public void AddWeapon(Weapon weapon) => _items.Add(weapon);

        public bool HasWeapon(Weapon weapon) => _items.Contains(weapon);

        public void SortByDefault() => _items.Sort();

        public void Sort(IComparer<Weapon> comparer) => _items.Sort(comparer);

        public void PrintAll(string title)
        {
            Console.WriteLine($"\n=== {title} ===");
            foreach (var w in _items)
                Console.WriteLine(w);
        }
    }

}
