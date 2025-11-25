namespace AdapterPattern;

// Concrete Adapter B
class HyteraRadioAdapter : IRadioAdapter
{
    private readonly HyteraRadio hyteraRadio;
    private readonly string pincode;

    public HyteraRadioAdapter(HyteraRadio hyteraRadio, string pincode)
    {
        this.hyteraRadio = hyteraRadio;
        this.pincode = pincode;
    }

    public void Send(string message, byte channel)
    {
        hyteraRadio.Init(pincode);

        hyteraRadio.SendMessage(10, message);

        hyteraRadio.Release();
    }
}

