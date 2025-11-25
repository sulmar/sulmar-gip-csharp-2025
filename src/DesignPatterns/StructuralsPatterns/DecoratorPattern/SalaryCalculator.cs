namespace DecoratorPattern;

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

