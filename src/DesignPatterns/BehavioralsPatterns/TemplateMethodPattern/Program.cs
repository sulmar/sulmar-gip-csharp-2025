// See https://aka.ms/new-console-template for more information
using TemplateMethodPattern;

Console.WriteLine("Hello, World!");

Order order = new Order { TotalAmount = 1000, OrderDate = DateTime.Parse("2025-11-26 08:30") };

TimeSpan from = TimeSpan.Parse("08:30");
TimeSpan to = TimeSpan.Parse("15:30");

HappyHoursOrderCalculator calculator = new HappyHoursOrderCalculator(from, to, 0.1m);
var result = calculator.CalculateDiscount(order);

Console.WriteLine($"{result:C2}");