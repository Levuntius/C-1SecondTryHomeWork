namespace C_1SecondTryHomeWork.Enemy_types
{
    class Orc : Enemy
    {
        public override int AttackDamage { get; } = 60;
        public Orc(string name) : base(name, 100, 100) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} бьёт огромной дубиной по {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);
        }
    }
}

