// See https://aka.ms/new-console-template for more information
using TemplateMethodPattern;

Console.WriteLine("Hello, World!");

Order order = new Order { TotalAmount = 1000, OrderDate = DateTime.Parse("2025-11-26 08:59") };

HappyHoursOrderCalculator calculator = new HappyHoursOrderCalculator(9, 15, 0.1m);
var result = calculator.CalculateDiscount(order);

Console.WriteLine($"{result:C2}");