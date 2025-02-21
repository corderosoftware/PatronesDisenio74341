using AbstractFactory.ConcreteClasses;
namespace AbstractFactory.Factories;
internal class StripeGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new StripeGateway();
    }

    public ITransactionLogger CreateTransactionLogger()
    {
        return new StripeTransactionLogger();
    }
}
