namespace Command;
public class AmazonCommand : ICommand
{
    private readonly SmartTV _tv;
    public AmazonCommand(SmartTV tv)
    {
        _tv = tv;
    }

    public string Execute()
    {
        return _tv.OpenAmazon();
    }
}
