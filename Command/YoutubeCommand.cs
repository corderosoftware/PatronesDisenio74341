namespace Command;

internal class YoutubeCommand : ICommand
{
    private readonly SmartTV _tv;
    public YoutubeCommand(SmartTV tv)
    {
        _tv = tv;
    }

    public string Execute()
    {
        return _tv.OpenYoutube();
    }
}
