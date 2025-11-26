using DecoratorPattern.Domain.Abstractions;
using DecoratorPattern.Domain.Models;

namespace DecoratorPattern.Application;

// Component
class BaseSalary : ISalaryDecorator
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.WorkHours* employee.AmountPerHour;
    }
}

