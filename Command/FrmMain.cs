namespace Command
{
    public partial class FrmMain : Form
    {
        SmartTV tv;
        RemoteControl control;
        public FrmMain()
        {
            InitializeComponent();
            tv = new SmartTV();
            control = new RemoteControl();
        }

        private void BtnNetFilx_Click(object sender, EventArgs e)
        {
            control.SetCommand(new NetFlixCommand(tv));
            LblInfo.Text = control.PressButton();
        }

        private void BtnAmazon_Click(object sender, EventArgs e)
        {
            control.SetCommand(new AmazonCommand(tv));
            LblInfo.Text = control.PressButton();
        }

        private void BtnYoutube_Click(object sender, EventArgs e)
        {
            control.SetCommand(new YoutubeCommand(tv));
            LblInfo.Text = control.PressButton();
        }
    }
}
