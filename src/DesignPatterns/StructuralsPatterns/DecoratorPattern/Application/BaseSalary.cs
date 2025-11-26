using DecoratorPattern.Abstractions;
using DecoratorPattern.Models;

namespace DecoratorPattern.Application;

// Component
class BaseSalary : ISalaryDecorator
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.WorkHours* employee.AmountPerHour;
    }
}

