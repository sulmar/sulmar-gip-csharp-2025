using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP.Warehouse;

// Klasa
public class Phone
{
    // Pola
    public string model;
    public string manufacture;
    public Battery? battery;
    public string color;
    public required string serialNumber;
    public decimal cost;

    // constructor
    // sluzy do ustawiania wartosci domyslnych oraz wymaganych parametrow
    public Phone(string model, string manufacture = "Nokia", Battery battery = null)
    {
        this.model = model;
        this.manufacture = manufacture;       
        this.battery = battery;
    }

    // Metoda
    public override string ToString()
    {
        return GetFullName();    
    }  

    public string GetFullName()
    {
        return $"model: {model} manufacture: {manufacture} color: {color} s/n: {serialNumber} {battery} cost: {cost:C2}";
    }


}
