using DecoratorPattern.Abstractions;
using DecoratorPattern.Models;

namespace DecoratorPattern.Application;

// Concrete Decorator C
class MentorSalaryDecorator : ISalaryDecorator
{
    private readonly ISalaryDecorator _salary;

    public MentorSalaryDecorator(ISalaryDecorator salary)
    {
        _salary = salary;
    }

    public decimal CalculateSalary(Employee employee)
    {
        return _salary.CalculateSalary(employee) * 1.1m; // +10%
    }
}

