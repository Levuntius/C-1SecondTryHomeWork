namespace C_1SecondTryHomeWork
{
    class Vampire : Enemy
    {
        public Vampire(string name) : base(name, 90) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} высасывает кровь у {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);

            int heal = AttackDamage / 2;
            Health += heal;

            Console.WriteLine($"{Name} восстанавливает {heal} здоровья. Теперь у него {Health} HP.");
        }
    }
}

