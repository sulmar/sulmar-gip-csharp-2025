using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorConsoleApp;

class NbpCurrencyRateProvider : IRateProvider   // Klasa NbpCurrencyRateProvider implementuje interfejs IRateProvider
{
    private readonly HttpClient _http;

    public NbpCurrencyRateProvider(HttpClient http)
    {
        _http = http;
    }

    public decimal GetRate(string currencyCode)
    {
        var url = $"https://api.nbp.pl/api/exchangerates/rates/A/{currencyCode}?format=json";

        NbpResponse data = _http.GetFromJsonAsync<NbpResponse>(url).Result;

        return data.Rates[0].Mid;
    }

    public List<decimal> GetTable()
    {
        throw new NotImplementedException();
    }


    public class NbpResponse
    {
        public string Table { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public List<NbpRate> Rates { get; set; }
    }

    public class NbpRate
    {
        public decimal Mid { get; set; }
    }
}
