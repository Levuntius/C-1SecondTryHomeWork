namespace C_1SecondTryHomeWork
{
    public class WeaponWeightComparer : IComparer<Weapon>
    {
        private readonly SortOrder order;

        public WeaponWeightComparer(SortOrder order)
        {
            this.order = order;
        }

        public int Compare(Weapon x, Weapon y)
        {
            return order == SortOrder.Ascending
                ? x.Weight.CompareTo(y.Weight)
                : y.Weight.CompareTo(x.Weight);
        }
    }

}
