namespace C_1SecondTryHomeWork
{
    public class Rune : IEquatable<Rune>
    {
        public string Element {get; set;}
        public int PowerBonus {get; set;}
        public int Tier {get; set;}

        public bool Equals(Rune other)
        {
            if (other == null) return false;
            return Element == other.Element && Tier == other.Tier;
        }

        public override bool Equals(object obj) => Equals(obj as Rune);

        public override int GetHashCode() => HashCode.Combine(Element, Tier);

        public override string ToString()
            => $"[Руна {Element} T{Tier} (+{PowerBonus})]";
    }

}
