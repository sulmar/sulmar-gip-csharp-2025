
using CurrencyCalculatorConsoleApp;

Console.WriteLine("Hello, World!");

decimal amount = 100;
string code = "EUR";

NbpCurrencyRateProvider provider = new NbpCurrencyRateProvider();

// Zasada Open-Closed (otwarte na rozszerzenie a zamknięte na modyfikacje)

// Logika
decimal rate = provider.GetRate(code);

decimal currencyAmount = amount * rate;

// UI
Console.WriteLine($"{amount:N2} {code} -> {currencyAmount:C2}");