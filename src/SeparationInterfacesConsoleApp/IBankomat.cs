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
    void Wplata(decimal kwota);
    decimal Saldo { get; }
}

class PkoBankomat : IBankomat
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


class PekaoBankomat : IBankomat
{
    private decimal _saldo;
    public decimal Saldo => _saldo;

    public void Wplata(decimal kwota)
    {
        throw new NotSupportedException();
    }

    public void Wyplata(decimal kwota)
    {
        if (kwota > _saldo)
            throw new InvalidOperationException();

        _saldo -= kwota;
    }
}
