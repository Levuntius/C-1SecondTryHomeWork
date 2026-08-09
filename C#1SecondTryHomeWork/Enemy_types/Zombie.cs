namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Zombie : Enemy
    {
        public Zombie(string name, int health, int? maxHealth = null) : base(name, health, maxHealth) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} кусает {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);

            Heal(10);
        }
    }
}

