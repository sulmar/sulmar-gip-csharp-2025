using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern;

internal class Message
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}


class MessageProcessor
{
    private string[] whitelist = new string[] { "john@domain.com", "bob@domain.com" };
    
    public string Process(Message message)
    {
        // 1. Walidacja nadawcy (biala lista)
        ValidateFromWhiteList(message);

        // 2. Weryfikacja tematu (czy zawiera nr zamowienia)
        ValidateSubjectOrderNumber(message);

        // 3. TODO: weryfikacja formatu adresu e-doreczen (AED)
        // AE:PL-XXXXX-XXXXX-YYYYY-ZZ        

        // 4. Ekstracja NIP z wiadomosci
        string nip = ValidateAndExtractNip(message);

        return nip;
    }

    private static string ValidateAndExtractNip(Message message)
    {
        string pattern = @"(\d{10}|\d{3}-\d{3}-\d{2}-\d{2}|\d{3}-\d{2}-\d{2}-\d{3})";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(message.Body);

        if (!match.Success)
        {
            throw new Exception("Bledny nr nip");
        }

        string nip = match.Value;
        return nip;
    }

    private static void ValidateSubjectOrderNumber(Message message)
    {
        if (!message.Subject.Contains("Nr zam"))
        {
            throw new Exception("Brak numeru zamowienia");
        }
    }

    private void ValidateFromWhiteList(Message message)
    {
        if (!whitelist.Contains(message.From))
        {
            throw new Exception("Nadawca spoza whitelist");
        }
    }
}
