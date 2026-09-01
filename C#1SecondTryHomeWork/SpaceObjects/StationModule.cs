namespace C_1SecondTryHomeWork;

public abstract class StationModule : SpaceObject
{
    public bool IsEnabled {get; private set;}
    public int EnergyConsumption {get;}

    protected StationModule(string name, int hull, int shield, int energyConsumption) : base(name, hull, shield)
    {
        EnergyConsumption = energyConsumption;
    }

    public void Enable() => IsEnabled = true;
    public void Disable() => IsEnabled = false;
}
