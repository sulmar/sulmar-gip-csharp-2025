using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern;

internal class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public int WorkHours { get; set; }
    public decimal AmountPerHour { get; set; }
    public int Seniority { get; set; }
}

internal class SalaryCalculator
{
    public decimal CalculateSalary(Employee employee)
    {
        // wynagrodzenie bazowe
        decimal baseSalary = employee.WorkHours * employee.AmountPerHour;

        // dodatek stazowy
        baseSalary += employee.Seniority * 10m;

        // dodatek za szkolenie
        

        return baseSalary;
    }
}


