namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Orc : Enemy
    {
        public Orc(string name, int health = 100, int? maxHealth = null) : base(name, health, maxHealth) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} бьёт огромной дубиной по {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);
        }
    }
}

