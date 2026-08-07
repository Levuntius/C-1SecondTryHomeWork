namespace C_1SecondTryHomeWork.Properties.Enemy_types
{
    class Skeleton : Enemy
    {
        public Skeleton(string name) : base(name, 50, 50) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} стреляет из костяного лука в {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);
        }
    }
}
