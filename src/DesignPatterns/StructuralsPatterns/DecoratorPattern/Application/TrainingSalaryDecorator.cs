using DecoratorPattern.Abstractions;
using DecoratorPattern.Models;

namespace DecoratorPattern.Application;

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

