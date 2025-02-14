namespace Decorator
{
    public partial class FrmMain : Form
    {
        IBurger burger;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnPedido_Click(object sender, EventArgs e)
        {
            burger = new BasicBurger();
            TxtMessage.Text = $"{burger.GetDescription()} : {burger.GetCost()}";
            BtnPedido.Enabled = false;
            BtnFinPedido.Enabled = true;
            BtnQueso.Enabled = true;
            BtnTocino.Enabled = true;
        }

        private void BtnFinPedido_Click(object sender, EventArgs e)
        {
            burger = null;
            TxtMessage.Text = string.Empty;
            BtnFinPedido.Enabled = false;
            BtnPedido.Enabled = true;
            BtnQueso.Enabled = false;
            BtnTocino.Enabled = false;

        }

        private void BtnTocino_Click(object sender, EventArgs e)
        {
            burger = new BaconDecorator(burger);
            ShowMessage();
        }

        private void BtnQueso_Click(object sender, EventArgs e)
        {
            burger = new CheeseDecorator(burger);
            ShowMessage();
        }
        private void ShowMessage()
        {
            TxtMessage.Text = $"{burger.GetDescription()} : {burger.GetCost()}";
        }
    }
}
