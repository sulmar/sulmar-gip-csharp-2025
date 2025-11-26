using DecoratorPattern.Domain.Models;

namespace DecoratorPattern.Domain.Abstractions;

// Abstract Decorator
interface ISalaryDecorator
{
    decimal CalculateSalary(Employee employee);
}

