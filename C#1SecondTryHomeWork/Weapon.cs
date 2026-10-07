namespace C_1SecondTryHomeWork
{
    public class Weapon : IEquatable<Weapon>, IComparable<Weapon>
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int BaseDamage {get; set;}
        public float Weight {get; set;}
        public List<Rune> Sockets {get; set;} = new();

        public int TotalDamage => BaseDamage + Sockets.Sum(r => r.PowerBonus);

        public void SocketRune(Rune rune) => Sockets.Add(rune);

        public bool Equals(Weapon other)
        {
            if (other == null) return false;
            return Id == other.Id;
        }

        public override bool Equals(object obj) => Equals(obj as Weapon);

        public override int GetHashCode() => Id.GetHashCode();

        // Сортировка по умолчанию — по урону, по убыванию
        public int CompareTo(Weapon other)
        {
            return other.TotalDamage.CompareTo(this.TotalDamage);
        }

        public override string ToString()
        {
            string runes = Sockets.Count == 0
                ? "Нет рун"
                : string.Join(", ", Sockets);

            return $"{Name}: Урон={TotalDamage} (База={BaseDamage}), Вес={Weight} кг, Руны: {runes}";
        }
    }

}
