namespace AdapterPattern;

// Concrete Adapter B
class HyteraRadioAdapter : IRadioAdapter
{
    private readonly HyteraRadio hyteraRadio;

    public HyteraRadioAdapter(HyteraRadio hyteraRadio)
    {
        this.hyteraRadio = hyteraRadio;
    }

    public void Send(string message, byte channel)
    {
        hyteraRadio.Init();

        hyteraRadio.SendMessage(10, message);

        hyteraRadio.Release();
    }
}

