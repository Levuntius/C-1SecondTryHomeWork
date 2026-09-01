namespace C_1SecondTryHomeWork;

public class SolarPanel : StationModule, IEnergyProducer
{
    public SolarPanel(string name): base(name, 80, 10, 0)
    {

    }

    public int ProduceEnergy() => 15;
}
