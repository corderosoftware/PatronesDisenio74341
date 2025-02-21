using AbstractFactory.ConcreteClasses;

namespace AbstractFactory.Factories;
internal class PayPalGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new PayPalGateway();
    }

    public ITransactionLogger CreateTransactionLogger()
    {
        return new PayPalTransactionLogger();
    }
}
