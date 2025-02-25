using State.Properties;
using System.Resources;

namespace State
{
    public partial class FrmMain : Form
    {
        StateContext context;
        public FrmMain()
        {
            InitializeComponent();
            context = new StateContext();
        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            context.Request();
            PicSemaforo.Image = (Image)Resources.ResourceManager.GetObject(context.State.PictureName);
        }
    }
}
