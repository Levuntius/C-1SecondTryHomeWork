namespace C_1SecondTryHomeWork
{
    public class WeaponRuneCountComparer : IComparer<Weapon>
    {
        private readonly SortOrder order;

        public WeaponRuneCountComparer(SortOrder order)
        {
            this.order = order;
        }

        public int Compare(Weapon x, Weapon y)
        {
            return order == SortOrder.Ascending
                ? x.Sockets.Count.CompareTo(y.Sockets.Count)
                : y.Sockets.Count.CompareTo(x.Sockets.Count);
        }
    }

