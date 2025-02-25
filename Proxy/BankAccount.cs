namespace Proxy;
public class BankAccount : IBankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        _balance = balance;
    }

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public double GetBalance()
    {
        return _balance;
    }

    public bool Withdraw(double amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }
}
