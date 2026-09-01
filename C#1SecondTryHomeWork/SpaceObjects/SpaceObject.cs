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
        if (Shield > 0)
        {
            int absorbed = Math.Min(Shield, amount);
            Shield -= absorbed;
            amount -= absorbed;
        }

        if (amount > 0)
            Hull -= amount;
    }
}
