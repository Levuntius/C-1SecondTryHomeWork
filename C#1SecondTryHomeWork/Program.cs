namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        class Player
        {
            public string Name { get; }
            public int Level { get; }

            public Player(string name, int level)
            {
                Name = name;
                Level = level;
            }

            // Переопределение Equals()
            public override bool Equals(object obj)
            {
                if (obj is Player other)
                {
                    return Name == other.Name && Level == other.Level;
                }

                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Name, Level);
            }

            // Переопределение ToString()
            public override string ToString()
            {
                return $"Player: {Name}, Level: {Level}";
            }
        }

    }
}