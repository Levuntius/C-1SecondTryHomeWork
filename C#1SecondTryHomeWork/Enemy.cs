namespace C_1SecondTryHomeWork
{
    public abstract class Enemy
    {
        protected const int BaseAttackDamage = 50;

        public string Name {get; private init;}
        public int AttackDamage {get; protected set;} = BaseAttackDamage;
        public int Health {get; private set;}
        public int MaxHealth {get; private init;}

        public bool IsDead => Health <= 0;

        public Enemy(string name, int health, int? maxHealth = null)
        {
            Name = name;
            Health = health;

            if (maxHealth != null)
            {
                if (maxHealth < health)
                    throw new Exception("MaxHealth cannot be less than Health");

                MaxHealth = (int)maxHealth;
            }
            else
            {
                MaxHealth = health;
            }
        }

        // Универсальный метод изменения HP
        public void ChangeHP(int amount)
        {
            Health += amount;

            if (Health > MaxHealth)
                Health = MaxHealth;

            if (Health < 0)
                Health = 0;
        }

        // Получение урона
        public virtual void DealDamage(int amount)
        {
            ChangeHP(-amount);

            Console.WriteLine($"{Name} получает {amount} урона. HP: {Health}/{MaxHealth}");
        }

        // Лечение
        public virtual void Heal(int amount)
        {
            ChangeHP(amount);

            Console.WriteLine($"{Name} лечится на {amount}. HP: {Health}/{MaxHealth}");
        }

        public virtual void Attack(Enemy target)
        {
            if (target == null)
                throw new NullReferenceException("target is null");

            Console.WriteLine($"{Name} атакует {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);
        }
    }
}
