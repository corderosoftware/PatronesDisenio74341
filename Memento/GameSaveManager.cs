namespace Memento;
public class GameSaveManager
{
    private List<GameMemento> saves = new List<GameMemento>();

    public void SaveGame(Game game)
    {
        saves.Add(game.SaveGame());
    }

    public void LoadGame(Game game, short saveMemento)
    {
        game.LoadGame(saves[saveMemento]);
    }

}
