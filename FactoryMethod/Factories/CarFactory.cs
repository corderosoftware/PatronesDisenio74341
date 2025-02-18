using FactoryMethod.Products;

namespace FactoryMethod.Factories;
public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}
