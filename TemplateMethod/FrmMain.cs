using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TemplateMethod
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnBanco_Click(object sender, EventArgs e)
        {
            ListActividades.Items.Clear();
            var Bank = new Banco();

            var Actividades = Bank.ContratarCandidato();

            foreach (var item in Actividades)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    ListActividades.Items.Add(item);
                }
            }
        }

        private void BtnSoftware_Click(object sender, EventArgs e)
        {
            ListActividades.Items.Clear();
            var Factory = new SoftwareFactory();

            var Actividades = Factory.ContratarCandidato();

            foreach (var item in Actividades)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    ListActividades.Items.Add(item);
                }
            }
        }
    }
}
