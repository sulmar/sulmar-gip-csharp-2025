namespace AdapterPattern;


// Wariant klasowy
class MotorolaRadioClassAdapter : MotorolaRadio,  IRadioAdapter
{
    public void Send(string message, byte channel)
    {
        base.PowerOn();

        base.SelectChannel(channel);

        base.Send(message);

        base.PowerOff();
    }
}
