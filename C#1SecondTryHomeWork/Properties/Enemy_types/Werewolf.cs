namespace C_1SecondTryHomeWork.Properties.Enemy_types
{
    class Werewolf : Enemy
    {
        public Werewolf(string name) : base(name, 80, 80) { }

        public override void Attack(Enemy target)
        {
            int damage = AttackDamage;

            if (Health < 40)
            {
                damage = 60;
                Console.WriteLine($"{Name} впадает в ярость!");
            }

            Console.WriteLine($"{Name} разрывает когтями {target.Name} и наносит {damage} урона!");
            target.TakeDamage(damage);
        }
    }
}

