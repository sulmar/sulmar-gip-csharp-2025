namespace AdapterPattern;

internal class MotorolaRadio
{
    private bool _enabled;

    private byte _selectedChannel;

    public MotorolaRadio()
    {
        _enabled = false;
    }

    public void PowerOn()
    {
        _enabled = true;
    }

    public void SelectChannel(byte channel)
    {
        _selectedChannel = channel;
    }

    public void Send(string message)
    {
        if (_enabled)
        {
            Console.WriteLine($"<xml><send channel={_selectedChannel}>{message}</xml>");
        }
    }

    public void PowerOff()
    {
        _enabled = false;
    }
}
