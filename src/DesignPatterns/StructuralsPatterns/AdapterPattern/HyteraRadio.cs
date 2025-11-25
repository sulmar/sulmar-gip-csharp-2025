namespace AdapterPattern;

internal sealed class HyteraRadio 
{
    private RadioStatus status;

    public void Init(string pincode)
    {
        if (pincode == "1234")
            status = RadioStatus.On;
    }

    public void SendMessage(byte channel, string message)
    {
        if (status == RadioStatus.On)
            Console.WriteLine($"CHANNEL: {channel}, MESSAGE: {message}");
    }

    public void Release()
    {
        status = RadioStatus.Off;
    }

}

public enum RadioStatus
{
    On,
    Off
}
