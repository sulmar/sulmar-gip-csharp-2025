// See https://aka.ms/new-console-template for more information
using StrategyPattern;

Console.WriteLine("Hello, World!");


Product product = new Product { Name = "a", UnitPrice = 100 };
decimal quantity = 3;

ProductCalculator calculator = new ProductCalculator();

var result = calculator.CalculatePrice(product, quantity);

Console.WriteLine($"{product.UnitPrice:C2} x {quantity} = {result:C2}");