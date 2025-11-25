// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Hello, World!");

Employee employee = new Employee { Name = "John", AmountPerHour = 100, WorkHours = 10, Seniority = 5 };

ISalaryDecorator salary = new BaseSalary();
salary = new SenioritySalaryDecorator(salary);
salary = new TrainingSalaryDecorator(ratio: 2, salary);

SalaryCalculator calculator = new SalaryCalculator(salary);

var result = calculator.CalculateSalary(employee);

Console.WriteLine($"{result:C2}");