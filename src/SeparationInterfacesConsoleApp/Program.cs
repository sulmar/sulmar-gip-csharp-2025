// See https://aka.ms/new-console-template for more information
using SeparationInterfacesConsoleApp;

Console.WriteLine("Hello, World!");

// Zasada Liskov

IBankomat bankomat = new PekaoBankomat();


if (bankomat is IWplatomat wplatomat)
{
    wplatomat.Wplata(200);
}

if (bankomat is ISaldomat saldomat)
    Console.WriteLine(saldomat.Saldo);

bankomat.Wyplata(150);

if (bankomat is IBankomatSaldo bankomatSaldo)
{
    Console.WriteLine(bankomatSaldo.Saldo);

    bankomat.Wyplata(20);
    Console.WriteLine(bankomatSaldo.Saldo);
}


// bankomat.Wyplata(50);