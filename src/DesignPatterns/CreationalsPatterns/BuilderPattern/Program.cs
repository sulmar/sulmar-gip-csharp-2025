// See https://aka.ms/new-console-template for more information
using BuilderPattern;
using static BuilderPattern.ReportBuilderFactory;

Console.WriteLine("Hello, World!");


Report report = new Report { Count = 10, TotalAmount = 1000, Title = "Raport sprzedazy" };


Console.WriteLine("Podaj format: (0) Text  (1) Html ");
var format = Console.ReadLine();

FormatType formatType = Enum.Parse<FormatType>(format);

ReportBuilderFactory factory = new ReportBuilderFactory();
var reportBuilder = factory.Create(report, formatType);

// Director
reportBuilder.AddHeader();
reportBuilder.AddContent();
reportBuilder.AddFooter();

var content = reportBuilder.Build();

Console.WriteLine(content);