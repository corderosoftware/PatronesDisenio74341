using FactoryMethod.Products;

namespace FactoryMethod.Factories;

public class MotoFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Motorcycle();
    }
}
