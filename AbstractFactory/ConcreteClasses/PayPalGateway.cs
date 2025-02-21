namespace AbstractFactory.ConcreteClasses;
internal class PayPalGateway : IPaymentGateway
{
    public bool ProcessPayment(decimal amount)
    {
        if (amount > 0) return true;
        else return false;
    }
}
