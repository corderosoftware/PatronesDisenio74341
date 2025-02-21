using AbstractFactory.Factories;

namespace AbstractFactory
{

    public partial class FrmMain : Form
    {
        IPaymentGatewayFactory paymentGatewayFactory;
        PaymentService paymentService;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            if (CmbTipo.Text.ToUpper() == "PAYPAL")
            {
                paymentGatewayFactory = new PayPalGatewayFactory();
                TxtMessage.Text = $"Procesando el pago de { TxtMonto.Text } con PayPal\r\n";

            }
            else
            {
                paymentGatewayFactory = new StripeGatewayFactory();
                TxtMessage.Text = $"Procesando el pago de {TxtMonto.Text} con Stripe\r\n";
            }

            
            // Inyectar la fábrica de pasarela de pago en el servicio de pago.
            paymentService = new PaymentService(paymentGatewayFactory);
            
            //Procesamos el pago

            TxtMessage.Text += paymentService.ProcessPayment(decimal.Parse(TxtMonto.Text));

        }
    }
}
