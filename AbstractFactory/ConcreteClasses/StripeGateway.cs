namespace AbstractFactory.ConcreteClasses;
public class StripeGateway : IPaymentGateway
{
    public bool ProcessPayment(decimal amount)
    {
        if (amount > 0) return true;
        else return false;
    }
}
