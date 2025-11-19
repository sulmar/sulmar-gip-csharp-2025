using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP.Warehouse;

public class Battery
{
    public float Capacity;
    public float Level; // 0 = 0% 0.5 = 50% 1 = 100% 

    // konstruktor
    public Battery()
    {
        Level = 1;
    }
}

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
    public void Display()
    {
        Console.WriteLine($"model: {model} manufacture: {manufacture} color: {color} s/n: {serialNumber} capacity: {battery.Capacity} level: {battery.Level:P2} cost: {cost:C2}");
    }

}
