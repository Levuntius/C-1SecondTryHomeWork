namespace C_1SecondTryHomeWork
{
    class Dragon : Enemy
    {
        public override int AttackDamage {get;} = 70;

        public Dragon(string name) : base(name, 100) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} дышит огнём на {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);
        }
    }
}

