namespace CurrencyCalculatorConsoleApp;

// Kontrakt
interface IRateProvider
{
    decimal GetRate(string currencyCode); // Sygnatura metody    
}
