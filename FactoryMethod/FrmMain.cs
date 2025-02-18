using FactoryMethod.Factories;

namespace FactoryMethod
{
    public partial class FrmMain : Form
    {
        IVehicle vehicle;
        VehicleFactory vehicleFactory;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            vehicleFactory = new CarFactory();
            TxtMessage.Text = string.Empty;
        }

        private void BtnProbar_Click(object sender, EventArgs e)
        {
            if (vehicleFactory != null)
            {
                vehicle = vehicleFactory.OrderVehicle();
                TxtMessage.Text = $"Se ha creado un {vehicle.GetType().Name}\r\n";
                TxtMessage.Text += $"{vehicle.Start()}\r\n";
                TxtMessage.Text += $"{vehicle.Drive()}\r\n";
                TxtMessage.Text += $"{vehicle.Stop()}";
            }
            else
            {
                MessageBox.Show("Debe crear un Vehiculo");
            }
        }

        private void BtnMoto_Click(object sender, EventArgs e)
        {
            vehicleFactory = new MotoFactory();
            TxtMessage.Text = string.Empty;
        }

        private void BtnBici_Click(object sender, EventArgs e)
        {
            vehicleFactory = new BikeFactory();
            TxtMessage.Text = string.Empty;
        }
    }
}
