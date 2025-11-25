// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");

MotorolaRadio radio = new MotorolaRadio();

radio.PowerOn();

radio.SelectChannel(10);

radio.Send("Hello World!");

radio.PowerOff();