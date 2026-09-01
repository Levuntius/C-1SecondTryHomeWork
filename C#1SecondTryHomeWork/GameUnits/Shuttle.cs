namespace C_1SecondTryHomeWork;

public class Shuttle : Ship, ICargoCarrier
{
    public int Cargo {get; private set;}

    public Shuttle(string name): base(name, 120, 40, 300, 8)
    {

    }

    public void LoadCargo(int amount) => Cargo += amount;

    public void UnloadCargo() => Cargo = 0;
}
