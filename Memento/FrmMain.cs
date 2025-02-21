namespace Memento
{
    public partial class FrmMain : Form
    {
        Game game;
        GameSaveManager saveManager;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            //Implementamos
            game = new Game();
            saveManager = new GameSaveManager();
            TxtMessage.Text = "Arranco el juego...";

            BtnLevel1.Enabled = true;
            BtnLevel2.Enabled = false;
            BtnLevel3.Enabled = false;
            CmbLevel.Enabled = false;
            BtnMemento.Enabled = false;
        }

        private void BtnLevel1_Click(object sender, EventArgs e)
        {
            //Implementar Nivel 1 
            game.CurrentState = new GameState { Level = 1, Health = 100, Weapon = "Espada" };
            saveManager.SaveGame(game);
            TxtMessage.Text = $"El Jugador alcanzó: { game.ShowCurrentState() }\r\n";
            TxtMessage.Text += "Juego salvado";

            BtnLevel1.Enabled = false;
            BtnLevel2.Enabled = true;
            BtnLevel3.Enabled = false;
            CmbLevel.Enabled = false;
            BtnMemento.Enabled = false;
        }

        private void BtnLevel2_Click(object sender, EventArgs e)
        {
            //Implementar Nivel 2 
            game.CurrentState = new GameState { Level = 2, Health = 80, Weapon = "Martillo" };
            saveManager.SaveGame(game);
            TxtMessage.Text = $"El Jugador alcanzó: {game.ShowCurrentState()}\r\n";
            TxtMessage.Text += "Juego salvado";

            BtnLevel1.Enabled = false;
            BtnLevel2.Enabled = false;
            BtnLevel3.Enabled = true;
            CmbLevel.Enabled = false;
            BtnMemento.Enabled = false;
        }

        private void BtnLevel3_Click(object sender, EventArgs e)
        {
            //Implementar Nivel 3 
            game.CurrentState = new GameState { Level = 3, Health = 40, Weapon = "Pistola de Agua" };
            saveManager.SaveGame(game);
            TxtMessage.Text = $"El Jugador alcanzó: {game.ShowCurrentState()}\r\n";
            TxtMessage.Text += "Juego salvado";

            BtnLevel1.Enabled = false;
            BtnLevel2.Enabled = false;
            BtnLevel3.Enabled = false;
            CmbLevel.Enabled = true;
            BtnMemento.Enabled = true;
        }

        private void BtnMemento_Click(object sender, EventArgs e)
        {
            saveManager.LoadGame(game, short.Parse(CmbLevel.SelectedIndex.ToString()));
            TxtMessage.Text = $"Juego Cargado. Hemos vuelto a:{ game.ShowCurrentState() }";
        }
    }
}
