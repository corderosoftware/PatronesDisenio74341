namespace AbstractFactory;
public interface IPaymentGatewayFactory
{
    IPaymentGateway CreatePaymentGateway();
    ITransactionLogger CreateTransactionLogger();
}
