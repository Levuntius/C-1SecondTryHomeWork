namespace C_1SecondTryHomeWork
{
    class Zombie : Enemy
    {
        public Zombie(string name) : base(name, 120) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} кусает {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);

            Health += 10;
            Console.WriteLine($"{Name} регенерирует 10 здоровья. Теперь у него {Health} HP.");
        }
    }
}

