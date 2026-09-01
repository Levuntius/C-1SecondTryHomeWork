namespace C_1SecondTryHomeWork;

public abstract class Ship : SpaceObject
{
    public int Fuel {get; protected set;}
    public int Speed {get; protected set;}

    protected Ship(string name, int hull, int shield, int fuel, int speed) : base(name, hull, shield)
    {
        Fuel = fuel;
        Speed = speed;
    }
}
