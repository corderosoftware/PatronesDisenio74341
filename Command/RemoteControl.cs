namespace Command;
public class RemoteControl
{
    protected ICommand _command;

    //public RemoteControl(ICommand command)
    //{
    //    _command = command;
    //}

    public void SetCommand(ICommand command)
    {
        _command = command;
    }
    public string PressButton()
    {
        return _command.Execute();
    }
}
