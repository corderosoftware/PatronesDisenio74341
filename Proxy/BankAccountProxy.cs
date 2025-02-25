namespace Proxy;
public class BankAccountProxy : IBankAccount
{
    private BankAccount _realAccount;

    public BankAccountProxy(BankAccount bankAccount)
    {
        _realAccount = bankAccount;
    }

    public void Deposit(double amount)
    {
        _realAccount.Deposit(amount);
    }

    public double GetBalance()
    {
        return _realAccount.GetBalance();
    }

    public bool Withdraw(double amount)
    {
        if(amount > 20000)
        {
            MessageBox.Show("Necesita la aprobación del Gerente para retiros > 20000");
            return false;
        }
        else
        {
            return _realAccount.Withdraw(amount);
        }
    }
}
