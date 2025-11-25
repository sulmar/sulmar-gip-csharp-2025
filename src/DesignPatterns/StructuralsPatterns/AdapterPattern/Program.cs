// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");

while (true)
{
    Console.Write("Podaj producenta (M)otorola (H)ytera: ");

    string selectedRadio = Console.ReadLine();

    string message = "Hello World!";

    if (selectedRadio == "M")
    {
        MotorolaRadio motorolaRadio = new MotorolaRadio();

        motorolaRadio.PowerOn();

        motorolaRadio.SelectChannel(10);

        motorolaRadio.Send(message);

        motorolaRadio.PowerOff();
    }

    else if (selectedRadio == "H")
    {
        HyteraRadio hyteraRadio = new HyteraRadio();

        hyteraRadio.Init();

        hyteraRadio.SendMessage(10, message);

        hyteraRadio.Release();
    }
}



