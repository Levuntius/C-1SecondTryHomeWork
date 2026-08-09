namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Dragon : Enemy
    {
        public Dragon(string name, int health = 120, int? maxHealth = null) : base(name, health, maxHealth)
        {
            AttackDamage = 70;
        }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} дышит огнём на {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);
        }
    }
}

