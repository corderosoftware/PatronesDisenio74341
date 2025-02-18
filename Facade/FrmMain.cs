namespace Facade
{
    public partial class FrmMain : Form
    {
        HomeTheaterFacade homeTheater;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TxtMessage.Text = homeTheater.EndMovie();
            
            BtnMovie.Enabled = true;
            BtnStop.Enabled = false;
        }

        private void BtnMovie_Click(object sender, EventArgs e)
        {
            DvdPlayer dvdPlayer = new DvdPlayer();
            Proyector proyector = new Proyector();
            Speakers speakers = new Speakers();

            homeTheater = new HomeTheaterFacade(dvdPlayer,proyector,speakers);
            TxtMessage.Text = homeTheater.WatchMovie("El Rey Leon");
                        
            BtnMovie.Enabled = false;
            BtnStop.Enabled = true;
        }
    }
}
