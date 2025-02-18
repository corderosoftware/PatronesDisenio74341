namespace FactoryMethod.Products;
public class Motorcycle : IVehicle
{
    public string Drive()
    {
        return "Montado en la Moto";
    }

    public string Start()
    {
        return "Encendiendo la Moto";
    }

    public string Stop()
    {
        return "Detener la Moto";
    }
}
