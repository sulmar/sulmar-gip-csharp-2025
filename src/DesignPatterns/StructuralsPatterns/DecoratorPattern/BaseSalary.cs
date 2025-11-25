namespace DecoratorPattern;

// Component
class BaseSalary : ISalaryDecorator
{
    public decimal CalculateSalary(Employee employee)
    {
        return employee.WorkHours* employee.AmountPerHour;
    }
}

