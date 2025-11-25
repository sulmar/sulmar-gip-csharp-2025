// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Hello, World!");

Employee employee = new Employee { Name = "John", AmountPerHour = 100, WorkHours = 10, Seniority = 5 };

// Director
ISalaryBuilder salaryBuilder = new SalaryBuilder();
salaryBuilder.AddSeniority(); 
salaryBuilder.AddTraining(2);
salaryBuilder.AddTraining(2);
salaryBuilder.AddMentor();

ISalaryDecorator salary = salaryBuilder.Build();

SalaryCalculator calculator = new SalaryCalculator(salary);

var result = calculator.CalculateSalary(employee);

Console.WriteLine($"{result:C2}");