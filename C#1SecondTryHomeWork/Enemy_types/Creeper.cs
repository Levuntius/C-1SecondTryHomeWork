namespace C_1SecondTryHomeWork.Enemy_types
{
    class Creeper : Enemy
    {
        public override int AttackDamage { get; } = 100;

        public Creeper(string name) : base(name, 100) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} взрывается рядом с {target.Name} и наносит {AttackDamage} урона!");

            // Наносим урон цели
            target.TakeDamage(AttackDamage);

            // Крипер самоуничтожается
            Health = 0;
            Console.WriteLine($"{Name} взорвался и погиб!");
        }
    }
}

