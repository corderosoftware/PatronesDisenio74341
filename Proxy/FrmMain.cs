namespace Proxy
{
    public partial class FrmMain : Form
    {
        BankAccount realAccount;
        BankAccountProxy accountProxy;

        public FrmMain()
        {
            InitializeComponent();
            realAccount = new BankAccount(100000);
            accountProxy = new BankAccountProxy(realAccount);
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            bool result = accountProxy.Withdraw(double.Parse(TxtMonto.Text));
            if (result)
            {
                MessageBox.Show($"Retiro exitoso. El saldo ahora es { accountProxy.GetBalance() }");
            }
            else
            {
                MessageBox.Show("El Retiro no es posible en estos momentos");
            }
        }
    }
}
