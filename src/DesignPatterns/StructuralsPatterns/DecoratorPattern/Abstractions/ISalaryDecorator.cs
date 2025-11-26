using DecoratorPattern.Models;

namespace DecoratorPattern.Abstractions;

// Abstract Decorator
interface ISalaryDecorator
{
    decimal CalculateSalary(Employee employee);
}

