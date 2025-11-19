using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP.Warehouse;

// Klasa
public class Phone
{
    private bool isPowerOn;

    // Wlasciwosci
    public string Model { get; private set; }
    public string Manufacture { get; set; }
    public Battery? Battery { get; set; }
    public string Color { get; set; }
    public required string SerialNumber { get; set; }
    public decimal Cost { get; set; }

    // constructor
    // sluzy do ustawiania wartosci domyslnych oraz wymaganych parametrow
    public Phone(string model, string manufacture = "Nokia", Battery battery = null)
    {
        this.Model = model;
        this.Manufacture = manufacture;       
        this.Battery = battery;
    }

    // Metoda
    public override string ToString()
    {
        Model = "a";

        return GetFullName();    
    }  

    public string GetFullName()
    {
        return $"model: {Model} manufacture: {Manufacture} color: {Color} s/n: {SerialNumber} {Battery} cost: {Cost:C2}";
    }


}
