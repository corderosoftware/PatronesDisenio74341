namespace FactoryMethod.Products;
public class Car : IVehicle
{
    public string Drive()
    {
        return "Montado en el Auto";
    }

    public string Start()
    {
        return "Encendiendo el Auto";
    }

    public string Stop()
    {
        return "Detener el Auto";
    }
}
