
using CurrencyCalculatorConsoleApp;

Console.WriteLine("Hello, World!");

decimal amount = 100;
string code = "EUR";

NbpCurrencyRateProvider provider = new NbpCurrencyRateProvider();

decimal rate = provider.GetRate(code);

decimal currencyAmount = amount * rate;

Console.WriteLine($"{amount:N2} {code} -> {currencyAmount:C2}");