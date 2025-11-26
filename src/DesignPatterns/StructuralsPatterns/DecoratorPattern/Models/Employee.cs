using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models;

internal class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public int WorkHours { get; set; }
    public decimal AmountPerHour { get; set; }
    public int Seniority { get; set; }
}

