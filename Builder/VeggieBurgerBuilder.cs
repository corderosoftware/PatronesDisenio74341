namespace Builder;

public class VeggieBurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new();
    public void AddBread() => _burger.Bread = "Pan Vegano";

    public void AddCheese() => _burger.Cheese = "Queso vegano";

    public void AddDressing() => _burger.Dressing = "Mayonesa vegana";

    public void AddLettuce() => _burger.Lettuce = true;

    public void AddMeat() => _burger.Meat = "Patty de Lentejas";

    public void AddTomato() => _burger.Tomato = true;

    public Burger GetBurger() => _burger;
}
