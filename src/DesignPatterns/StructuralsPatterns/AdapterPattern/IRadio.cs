namespace AdapterPattern;

// Abstract Adapter
interface IRadioAdapter
{
    void Send(string message, byte channel);
}