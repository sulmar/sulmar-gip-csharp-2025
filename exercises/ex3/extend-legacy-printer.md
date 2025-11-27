## Ćwiczenie - Rozszerzenie funkcjonalności drukarki

## Opis
System drukowania wymaga rozszerzenia funkcjonalności, zachowując zgodność z istniejącą klasą _LegacyPrinter_, której **nie można modyfikować**.
```cs
public class LegacyPrinter
{
    public void PrintDocument(string document)
    {
        Console.WriteLine($"Legacy Printer is printing: {document}");
    }
}
```

## Zadanie

Utwórz nową klasę _EnhancedPrinter_, która rozszerzy możliwości drukowania poprzez dodanie poniższych funkcjonalności.


## Wymagania funkcjonalne

1. Możliwość drukowania wielu kopii dokumentu.
2. Zapewnienie zgodności z istniejącą klasą `LegacyPrinter` bez jej modyfikacji.

## Wymagania niefunkcjonalne
- Kod powinien być czytelny i łatwy do dalszego rozwoju
- Wskazówka: zastosuj wzorce projektowe

## Oczekiwany rezultat
```
Legacy Printer is printing: Hello, World!
Legacy Printer is printing: Hello, World!
Legacy Printer is printing: Hello, World!
```