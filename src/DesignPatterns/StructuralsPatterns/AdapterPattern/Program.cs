// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");

RadioAdapterFactory factory = new RadioAdapterFactory();

while (true)
{
    Console.Write("Podaj producenta (M)otorola (H)ytera: ");

    string selectedRadio = Console.ReadLine();

    string message = "Hello World!";

    IRadioAdapter radio = factory.Create(selectedRadio);

    radio.Send("Hello World!", 10);
}



