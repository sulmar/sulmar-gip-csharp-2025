using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern;

internal class PrinterFactory
{
    public IPrinter Create(string model)
    {
        switch (model)
        {
            case "legacy": return new LegacyPrinterAdapter(new LegacyPrinter());

            default:
                return new EnhancedPrinter();
        }
    }
}
