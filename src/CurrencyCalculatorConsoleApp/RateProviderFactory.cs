using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculatorConsoleApp;


// Wzorzec fabryki (Fabric)

class RateProviderFactory
{
    // Fabryka zwraca Product
    public IRateProvider Create(string providerName)
    {
        switch (providerName)
        {
            case "Nbp":
                return new NbpCurrencyRateProvider();
            case "Forex":
                return new ForexCurrencyRateProvider();
            default:
                throw new NotSupportedException();
        }
    }
}
