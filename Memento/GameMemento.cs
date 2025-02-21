namespace Memento;

public class GameMemento
{
   public GameState State { get; private set; }

   public GameMemento(GameState gameState)
    {
        State = gameState;
    }
}
