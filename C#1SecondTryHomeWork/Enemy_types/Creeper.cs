namespace C_1SecondTryHomeWork.Enemy_types
{
    public class Creeper : Enemy
    {
        public Creeper(string name, int health, int? maxHealth = null) : base(name, health, maxHealth) { }

        public override void Attack(Enemy target)
        {
            Console.WriteLine($"{Name} взрывается рядом с {target.Name} и наносит 100 урона!");
            target.DealDamage(100);

            ChangeHP(-MaxHealth); // смерть
            Console.WriteLine($"{Name} погиб от взрыва!");
        }
    }
}

