using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeparationInterfacesConsoleApp;

 // Zasada Separacji Interfejsów
internal interface IBankomat
{
    void Wyplata(decimal kwota);       
}

interface IWplatomat
{
    void Wplata(decimal kwota);
}

interface ISaldomat
{
    decimal Saldo { get; }
}

interface IBankomatSaldo : IBankomat, ISaldomat
{

}

class PkoBankomat : IBankomat, IWplatomat, ISaldomat
{
    private decimal _saldo;

    public decimal Saldo => _saldo;

    public void Wplata(decimal kwota)
    {
        _saldo += kwota;
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota > _saldo)
            throw new InvalidOperationException();

        _saldo -= kwota;
    }
}


class PekaoBankomat : IBankomatSaldo
{
    private decimal _saldo;
    public decimal Saldo => _saldo;

    public void Wyplata(decimal kwota)
    {
        if (kwota > _saldo)
            throw new InvalidOperationException();

        _saldo -= kwota;
    }
}
