using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern;

internal class Message
{
    public string From { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}


class MessageProcessor
{
    private string[] whitelist = new string[] { "john@domain.com", "bob@domain.com" };
    
    public string Process(Message message)
    {
        throw new NotImplementedException();

        // 1. Walidacja nadawcy (biala lista)
        if (!whitelist.Contains(message.From))
        {
            throw new Exception("Nadawca spoza whitelist");
        }    

        // 2. Weryfikacja tematu (czy zawiera nr zamowienia)
        if (!message.Subject.Contains("Nr zam"))
        {
            throw new Exception("Brak numeru zamowienia");
        }


        // 3. TODO: weryfikacja adresu e-doreczen (AED)

        // 4. Ekstracja NIP z wiadomosci
        string pattern = "";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(message.Body);

        if (!match.Success)
        {
            throw new Exception("Bledny nr nip");
        }

        string nip = match.Value;
       

        return nip;
    }
}
