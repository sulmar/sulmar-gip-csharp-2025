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
    private ISalaryDecorator salaryDecorator;

    public SalaryCalculator(ISalaryDecorator salaryDecorator)
    {
        this.salaryDecorator = salaryDecorator;
    }

    public decimal CalculateSalary(Employee employee)
    {
        return salaryDecorator.CalculateSalary(employee);               
    }
}

// Abstract Decorator
interface ISalaryDecorator
{
    decimal CalculateSalary(Employee employee);
}

// Component
class BaseSalary : ISalaryDecorator
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.WorkHours* employee.AmountPerHour;
    }
}

// Concrete Decorator A
class SenioritySalaryDecorator : ISalaryDecorator
{
    // decoratee
    private readonly ISalaryDecorator _salary;

    private const decimal amountPerYear = 10m;

    public SenioritySalaryDecorator(ISalaryDecorator salary)
    {
        this._salary = salary;
    }

    public decimal CalculateSalary(Employee employee)
    {
        return _salary.CalculateSalary(employee) + employee.Seniority * amountPerYear;
    }
}

// Concrete Decorator B
class TrainingSalaryDecorator : ISalaryDecorator
{
    // decoratee
    private readonly ISalaryDecorator _salary;
    private readonly int ratio;

    public TrainingSalaryDecorator(int ratio, ISalaryDecorator salary)
    {
        _salary = salary;
        this.ratio = ratio;
    }

    public decimal CalculateSalary(Employee employee)
    {
        return _salary.CalculateSalary(employee) * ratio;
    }
}

