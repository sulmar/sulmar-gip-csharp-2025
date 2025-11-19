using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GIP.Warehouse;


// Klasa
public abstract class Phone // abstrakt - nie mozna utworzyc instancji tej klasy
{
    protected bool isPowerOn;

    // Wlasciwosci
    public string Model { get; private set; }
    public string Manufacture { get; set; }
    
    public string Color { get; set; }
    public required string SerialNumber { get; set; }
    public decimal Cost { get; set; }    

    // constructor
    // sluzy do ustawiania wartosci domyslnych oraz wymaganych parametrow
    public Phone(string model, string manufacture = "Nokia")
    {
        this.Model = model;
        this.Manufacture = manufacture;               
    }

    // Metoda
    public override string ToString()
    {
        return GetFullName();    
    }  

    public string GetFullName()
    {
        return $"model: {Model} manufacture: {Manufacture} color: {Color} s/n: {SerialNumber} cost: {Cost:C2}";
    }


}
