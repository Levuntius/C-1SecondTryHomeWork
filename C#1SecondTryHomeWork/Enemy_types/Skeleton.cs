namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Skeleton : Enemy
    {
        public Skeleton(string name, int health = 60, int? maxHealth = null) : base(name, health, maxHealth) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} стреляет из костяного лука в {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);
        }
    }
}
