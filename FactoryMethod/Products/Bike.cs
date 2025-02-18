namespace FactoryMethod.Products;
public class Bike : IVehicle
{
    public string Drive()
    {
        return "Montado en la Bici";
    }

    public string Start()
    {
        return "Encendiendo la Bici";
    }

    public string Stop()
    {
        return "Detener la Bici";
    }
}
