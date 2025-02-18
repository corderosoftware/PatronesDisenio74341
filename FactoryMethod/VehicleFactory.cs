namespace FactoryMethod;
public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();
    public IVehicle OrderVehicle()
    {
        IVehicle vehicle = CreateVehicle();
        return vehicle;
    }
}
