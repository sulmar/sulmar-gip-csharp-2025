using DecoratorPattern.Domain.Abstractions;
using DecoratorPattern.Domain.Models;

namespace DecoratorPattern.Application;

// Concrete Decorator A
class SenioritySalaryDecorator : ISalaryDecorator
{
    // decoratee
    private readonly ISalaryDecorator _salary;

    private const decimal amountPerYear = 10m;

    public SenioritySalaryDecorator(ISalaryDecorator salary)
    {
        _salary = salary;
    }

    public decimal CalculateSalary(Employee employee)
    {
        return _salary.CalculateSalary(employee) + employee.Seniority * amountPerYear;
    }
}

