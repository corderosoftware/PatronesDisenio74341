namespace Decorator;
public class BaconDecorator : BurgerDecorator
{
    public BaconDecorator(IBurger burger) : base(burger) {}

    public override string GetDescription()
    {
        return base.GetDescription() + ", Panceta";
    }

    public override double GetCost()
    {
        return base.GetCost() + 3000;
    }

}
