namespace AdapterPattern;

// Concrete Adapter A
class MotorolaRadioAdapter : IRadioAdapter
{
    // Adaptee
    private readonly MotorolaRadio motorolaRadio;

    public MotorolaRadioAdapter(MotorolaRadio radio)
    {
        motorolaRadio = radio;
    }

    public void Send(string message, byte channel)
    {
        motorolaRadio.PowerOn();

        motorolaRadio.SelectChannel(channel);

        motorolaRadio.Send(message);

        motorolaRadio.PowerOff();
    }
}

