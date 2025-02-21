using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;
internal class PaymentService
{
    private readonly IPaymentGateway _paymentGateway;
    private readonly ITransactionLogger _transactionLogger;

    public PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
    {
        //La Fabrica de ser capaz de crear el Gateway y el TransactionLog OJO comentar
        _paymentGateway = paymentGatewayFactory.CreatePaymentGateway();
        _transactionLogger = paymentGatewayFactory.CreateTransactionLogger();
    }

    public string ProcessPayment(decimal amount)
    {
        string Result = string.Empty;

        if (_paymentGateway.ProcessPayment(amount))
        {
            Result = _transactionLogger.LogTransaction($"El Pago de {amount}, fue éxitoso");
        }
        else
        {
            Result = _transactionLogger.LogTransaction($"El Pago de { amount }, es fallido.");
        }

        return Result;
    }
}
