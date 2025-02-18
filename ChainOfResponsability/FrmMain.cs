namespace ChainOfResponsability
{
    public partial class FrmMain : Form
    {
        AprobadorHandler PedroDirector;
        AprobadorHandler PabloVicePresidente;
        AprobadorHandler VilmaPresidente;
        public FrmMain()
        {
            InitializeComponent();
            //Establacemos la Cadena de Responsabilidad
            PedroDirector = new DirectorHandler();
            PabloVicePresidente = new VicePresidenteHandler();
            VilmaPresidente = new PresidenteHandler();

            PedroDirector.SetSucesor(PabloVicePresidente);
            PabloVicePresidente.SetSucesor(VilmaPresidente);

        }

        private void BtnAprobar_Click(object sender, EventArgs e)
        {
            //Generar y procesar la solicitud
            Compra solicitudCompra = new Compra(int.Parse(TxtNro.Text), double.Parse(TxtMonto.Text),TxtObjetivo.Text);
            PedroDirector.ProcesarSolicitud(solicitudCompra);
        }
    }

}
