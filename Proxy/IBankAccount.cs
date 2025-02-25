namespace Proxy;

public interface IBankAccount
{
    void Deposit(double amount);
    bool Withdraw(double amount);
    double GetBalance();
}
