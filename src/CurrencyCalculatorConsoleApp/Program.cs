
using CurrencyCalculatorConsoleApp;

Console.WriteLine("Hello, Interfaces!");

decimal amount = 100;
string code = "EUR";

string selectedProvider = "Nbp";

RateProviderFactory factory = new RateProviderFactory();

IRateProvider provider = factory.Create(selectedProvider);

// Zasada Open-Closed (otwarte na rozszerzenie a zamknięte na modyfikacje)
// Zasada Dependency Inversion (zasada odwracania zaleznosci)

// Logika
decimal rate = provider.GetRate(code);

decimal currencyAmount = amount * rate;

// UI
Console.WriteLine($"{amount:N2} {code} -> {currencyAmount:C2}");