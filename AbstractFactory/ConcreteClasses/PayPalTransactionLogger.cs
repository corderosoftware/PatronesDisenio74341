namespace AbstractFactory.ConcreteClasses;
internal class PayPalTransactionLogger : ITransactionLogger
{
    public string LogTransaction(string message)
    {
        return $"Registrar transacción en PayPal: {message}";
    }
}
