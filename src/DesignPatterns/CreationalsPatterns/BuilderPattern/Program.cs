// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");


Report report = new Report { Count = 10, TotalAmount = 1000, Title = "Raport sprzedazy" };

var content = report.Create();

Console.WriteLine(content);