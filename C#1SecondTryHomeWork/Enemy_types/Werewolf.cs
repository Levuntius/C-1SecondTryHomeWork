namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Werewolf : Enemy
    {
        private bool _isRage = false;

        public Werewolf(string name, int health = 90, int? maxHealth = null) : base(name, health, maxHealth) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} атакует когтями {target.Name} и наносит {AttackDamage} урона!");
            target.DealDamage(AttackDamage);
        }

        public override int TakeDamage(int damage)
        {
            // Включение ярости
            if (!_isRage && Health < MaxHealth / 2)
            {
                _isRage = true;

                // Усиление урона ×1.5
                AttackDamage = (int)(BaseAttackDamage * 1.5);

                Console.WriteLine($"{Name} впадает в ярость! Урон увеличен до {AttackDamage}");
            }

            DealDamage(damage);
            return Health;
        }
    }
}

