namespace Command;

public class NetFlixCommand : ICommand
{
    private readonly SmartTV _tv;
    public NetFlixCommand(SmartTV tv)
    {
        _tv = tv;
    }

    public string Execute()
    {
        return _tv.OpenNetFlix();
    }
}
