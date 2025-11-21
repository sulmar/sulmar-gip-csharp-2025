using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp;

internal class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public RiskType Risk { get; set; } // 0 - niskie 1 - srednie 2 - wysokie

    public Customer()
    {
        Risk = RiskType.Middle;
    }

    public override string ToString()
    {
        return $"{Id} {Name} {Salary} {Risk}";
    }
}

// Typ wyliczeniowy
public enum RiskType 
{
    [Description("Niski")]
    Low,
    [Description("Sredni")]
    Middle,
    [Description("Wysoki")]
    High,
}
