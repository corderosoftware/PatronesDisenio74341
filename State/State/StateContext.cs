namespace State;

public class StateContext
{
    public IState State { get; set; }

    public StateContext()
    {
        //Implementar el estado inicial
        State = new RedState();
    }

    public void Request()
    {
        State.Handle(this);
    }

}
