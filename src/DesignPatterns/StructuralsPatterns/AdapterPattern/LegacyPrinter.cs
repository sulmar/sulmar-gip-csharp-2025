using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern;

public class LegacyPrinter
{
    public void PrintDocument(string document)
    {
        Console.WriteLine($"Legacy Printer is printing: {document}");
    }
}


public interface IPrinter
{
    public void Print(string document, byte copies = 1);
}

// Concrete Adapter A
public class LegacyPrinterAdapter : IPrinter
{
    // Adaptee
    private readonly LegacyPrinter _legacyPrinter;

    public LegacyPrinterAdapter(LegacyPrinter legacyPrinter)
    {
        _legacyPrinter = legacyPrinter;
    }

    public void Print(string document, byte copies = 1)
    {
        for (int i = 0; i < copies; i++)
        {
            _legacyPrinter.PrintDocument(document);
        }
    }
}

public class EnhancedPrinter : IPrinter
{
    public void Print(string document, byte copies = 1)
    {
        for (int i = 0; i < copies; i++)
        {
            Console.WriteLine($"{document} copy# {i}");
        }
    }
}
