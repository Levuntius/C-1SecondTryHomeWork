namespace C_1SecondTryHomeWork
{
    class Enemy
    {
        public string Name {get; protected init;}
        public int Health {get; protected set;}
        public int MaxHealth {get; protected init;}
        public virtual int AttackDamage {get;} = 50;

        public Enemy(string name, int health, int maxHealth)
        {
            Name = name;
            Health = health;
            maxHealth = health;
        }

        public virtual void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} делает обычный удар по {target.Name} и наносит {AttackDamage} урона!");
            target.TakeDamage(AttackDamage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health > 0)
            {
                Console.WriteLine($"{Name} ещё жив. Осталось здоровья: {Health}");
            }
            else
            {
                Console.WriteLine($"{Name} погиб!");
            }
        }
    }
}
