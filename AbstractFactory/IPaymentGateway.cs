namespace AbstractFactory;
public interface IPaymentGateway
{
    bool ProcessPayment(decimal amount);
}
