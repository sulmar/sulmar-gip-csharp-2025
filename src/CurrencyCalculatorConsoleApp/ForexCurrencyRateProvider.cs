namespace CurrencyCalculatorConsoleApp;

class ForexCurrencyRateProvider : IRateProvider
{
    public decimal GetRate(string currencyCode)
    {
        return Get(currencyCode);
    }

    private decimal Get(string currencyCode)
    {
        var rate = (decimal)(4 + Random.Shared.NextDouble());

        return rate;
    }
}
