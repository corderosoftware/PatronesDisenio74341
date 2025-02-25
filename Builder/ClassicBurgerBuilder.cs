namespace Builder;
public class ClassicBurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new();
    public void AddBread() => _burger.Bread = "Pan clásico";

    public void AddCheese() => _burger.Cheese = "Queso cheddar";

    public void AddDressing() => _burger.Dressing = "Salsas varias";

    public void AddLettuce() => _burger.Lettuce = true;

    public void AddMeat() => _burger.Meat = "Carne de res";

    public void AddTomato() => _burger.Tomato = true;

    public Burger GetBurger() => _burger;
}
