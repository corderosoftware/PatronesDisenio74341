namespace Memento;
public class Game
{
    public GameState CurrentState { get; set; }

    public GameMemento SaveGame() => new GameMemento(CurrentState);

    public void LoadGame(GameMemento gameMemento) => CurrentState = gameMemento.State;

    public string ShowCurrentState() => $"Level: { CurrentState.Level }" +
        $"\r\n Health: { CurrentState.Health }\r\nWeapon{CurrentState.Weapon}";
    

}
