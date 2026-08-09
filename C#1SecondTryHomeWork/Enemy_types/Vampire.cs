namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Vampire : Enemy
    {
        public Vampire(string name, int health, int? maxHealth = null) : base(name, health, maxHealth) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} высасывает кровь у {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);

            int heal = AttackDamage / 2;
            Heal(heal);
        }
    }
}

