// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Application;
using DecoratorPattern.Domain.Abstractions;
using DecoratorPattern.Domain.Models;
using DecoratorPattern.Infrastructures;

Console.WriteLine("Hello, World!");

Product product = new Product { Id = 1, Name = "a", UnitPrice = 100m };

IPricingRepository pricingRepository = new DiscountProductDecorator(new FakeProductRepository(), new FakeDiscountRepository());
ProductCalculator productCalculator = new ProductCalculator(pricingRepository);

var total = productCalculator.Calculate(product, 3);

Console.WriteLine(total);

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