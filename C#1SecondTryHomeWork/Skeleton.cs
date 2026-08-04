namespace C_1SecondTryHomeWork
{
    class Skeleton : Enemy
    {
        public Skeleton(string name) : base(name, 50) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} стреляет из костяного лука в {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);
        }
    }
}

}
