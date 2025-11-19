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
    public float batteryCapacity;
    public float batteryLevel; // 0 = 0% 0.5 = 50% 1 = 100% 
    public string color;
    public required string serialNumber;
    public decimal cost;

    // constructor
    // sluzy do ustawiania wartosci domyslnych oraz wymaganych parametrow
    public Phone(string model, string manufacture = "Nokia")
    {
        this.model = model;
        this.manufacture = manufacture;

        batteryLevel = 1;
    }

    // Metoda
    public void Display()
    {
        Console.WriteLine($"model: {model} manufacture: {manufacture} color: {color} s/n: {serialNumber} level: {batteryLevel:P2} cost: {cost:C2}");
    }

}
