// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Console.WriteLine("Hello, World!");


Product product1 = new Product { Name = "a", UnitPrice = 100, Unit = Unit.szt };

decimal quantity = 3;

ProductCalculator calculator = new ProductCalculator();
var result = calculator.CalculatePrice(product1, quantity);
Console.WriteLine($"{product1.UnitPrice:C2} x {quantity} = {result:C2}");


calculator.SetStrategy(new OpenDoorPricingStrategy());

Product product2 = new Product { Name = "b", UnitPrice = 100, Unit = Unit.m2 };
var result2 = calculator.CalculatePrice(product2, quantity);

Console.WriteLine($"{product2.UnitPrice:C2} x {quantity} = {result2:C2}");