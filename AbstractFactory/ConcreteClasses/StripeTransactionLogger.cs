using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteClasses
{
    internal class StripeTransactionLogger : ITransactionLogger
    {
        public string LogTransaction(string message)
        {
            return $"Registrar transacción en Stripe: {message}";
        }
    }
}
