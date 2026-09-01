namespace C_1SecondTryHomeWork;

public abstract class SpaceObject : IDamageable
{
    public string Name {get;}
    public int Hull {get; protected set;}
    public int Shield {get; protected set;}

    protected SpaceObject(string name, int hull, int shield)
    {
        Name = name;
        Hull = hull;
        Shield = shield;
    }

    public void TakeDamage(int amount)
    {
        Console.WriteLine($"{Name} получает {amount} урона.");

        if (Shield > 0)
        {
            int absorbed = Math.Min(Shield, amount);
            Shield -= absorbed;
            amount -= absorbed;
            Console.WriteLine($" → Щит поглотил {absorbed}, осталось щита: {Shield}");
        }

        if (amount > 0)
        {
            Hull -= amount;
            Console.WriteLine($" → Корпус получил {amount}, осталось корпуса: {Hull}");
        }

        if (Hull <= 0)
        {
            Console.WriteLine($" !!! {Name} уничтожен!");
        }
    }

}
