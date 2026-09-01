namespace C_1SecondTryHomeWork;

public class DefenseTurret : StationModule, IAttacker
{
    public int Damage {get;}

    public DefenseTurret(string name): base(name, 150, 30, 10)
    {
        Damage = 20;
    }

    public void Attack(IDamageable target)
    {
        if (!IsEnabled)
        {
            Console.WriteLine($"{Name} не может атаковать модуль выключен.");
            return;
        }

        Console.WriteLine($"{Name} стреляет и наносит {Damage} урона!");
        target.TakeDamage(Damage);
    }

