// See https://aka.ms/new-console-template for more information
using SeparationInterfacesConsoleApp;

Console.WriteLine("Hello, World!");

// Zasada Liskov

IBankomat bankomat = new PekaoBankomat();

bankomat.Wplata(200);
Console.WriteLine(bankomat.Saldo);

bankomat.Wyplata(150);
Console.WriteLine(bankomat.Saldo);

bankomat.Wyplata(20);
Console.WriteLine(bankomat.Saldo);

// bankomat.Wyplata(50);