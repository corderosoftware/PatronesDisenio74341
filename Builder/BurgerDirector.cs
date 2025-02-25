namespace Builder;
public class BurgerDirector
{
    public void MakeBurger(IBurgerBuilder burgerBuilder)
    {
        burgerBuilder.AddBread();
        burgerBuilder.AddMeat();
        burgerBuilder.AddCheese();
        burgerBuilder.AddDressing();
        burgerBuilder.AddLettuce();
        burgerBuilder.AddTomato();
    }
}
