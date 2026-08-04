namespace C_1SecondTryHomeWork
{
    class Enemy
    {
        private string _name;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else
                    _health = value;
            }
        }

        public virtual int AttackDamage { get; } = 50;

        public Enemy(string name, int health)
        {
            _name = name;
            _health = health;
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

