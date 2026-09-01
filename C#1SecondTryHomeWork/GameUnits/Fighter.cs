namespace C_1SecondTryHomeWork;

public class Fighter : Ship, IAttacker
{
    public int Damage {get;}

    public Fighter(string name) : base(name, 100, 50, 200, 10)
    {
        Damage = 25;
    }

    public void Attack(IDamageable target)
    {
        target.TakeDamage(Damage);
    }
}
