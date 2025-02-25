namespace Builder
{
    public partial class FrmMain : Form
    {
        BurgerDirector chef = new BurgerDirector();
        ClassicBurgerBuilder classicBurgerBuilder;
        VeggieBurgerBuilder veggieBurgerBuilder;
        Burger burger;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClasic_Click(object sender, EventArgs e)
        {
            classicBurgerBuilder = new ClassicBurgerBuilder();
            chef.MakeBurger(classicBurgerBuilder);
            burger = classicBurgerBuilder.GetBurger();
            TxtMessage.Text = $"Classic Burger\r\n";
            TxtMessage.Text += burger.DisplayInformation();
        }

        private void BtnVeggie_Click(object sender, EventArgs e)
        {
            veggieBurgerBuilder = new VeggieBurgerBuilder();
            chef.MakeBurger(veggieBurgerBuilder);
            burger = veggieBurgerBuilder.GetBurger();
            TxtMessage.Text = $"Veggie Burger\r\n";
            TxtMessage.Text += burger.DisplayInformation();
        }
    }
}
