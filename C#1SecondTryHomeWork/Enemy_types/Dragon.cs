namespace C_1SecondTryHomeWork.Enemy_types
{
    class Dragon : Enemy
    {
        public override int AttackDamage {get;} = 70;

        public Dragon(string name) : base(name, 100, 100) { }

        public int maxHealth = 

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} дышит огнём на {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);
        }
    }
}

