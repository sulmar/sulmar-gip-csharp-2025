using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern;

internal class Message
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}


class MessageHandlerFactory
{
    public static IMessageHandler Create()
    {
        // 1. Walidacja nadawcy (biala lista)

        IMessageHandler validateWhiteListhandler = new ValidateFromWhiteListMessageHandler();

        // 2. Weryfikacja tematu (czy zawiera nr zamowienia)
        IMessageHandler subjectHandler = new ValidateSubjectOrderNumberMessageHandler();

        // 3. TODO: weryfikacja formatu adresu e-doreczen (AED)
        // AE:PL-XXXXX-XXXXX-YYYYY-ZZ        

        // 4. Ekstracja NIP z wiadomosci
        IMessageHandler nipHandler = new ValidateAndExtractNipMessageHandler();

        validateWhiteListhandler.SetNext(subjectHandler);
        subjectHandler.SetNext(nipHandler);

        return validateWhiteListhandler;
    }
}

class MessageProcessor
{
    IMessageHandler handler = null;

    public MessageProcessor(IMessageHandler handler)
    {
        this.handler = handler;
    }

    public string Process(Message message)
    {            
        handler.Handle(message);

        throw new NotImplementedException();

        // return nip;
    }

  

    

  
}

// Abstract Handler
interface IMessageHandler
{
    void Handle(Message message);
    void SetNext(IMessageHandler next);
}


// Base Handler
abstract class MessageHandler : IMessageHandler
{
    private IMessageHandler _next;
    public void SetNext(IMessageHandler next)
    {
        _next = next;
    }
    public virtual void Handle(Message message)
    {
        if (_next != null) 
            _next.Handle(message);
    }
}

// Concrete Handler A
class ValidateFromWhiteListMessageHandler : MessageHandler, IMessageHandler
{
    private string[] whitelist = new string[] { "john@domain.com", "bob@domain.com" };

    public override void Handle(Message message)
    {
        ValidateFromWhiteList(message);

        base.Handle(message);
    }

    private void ValidateFromWhiteList(Message message)
    {
        if (!whitelist.Contains(message.From))
        {
            throw new Exception("Nadawca spoza whitelist");
        }
    }
}

// Concrete Handler B
class ValidateSubjectOrderNumberMessageHandler : MessageHandler, IMessageHandler
{
    public override void Handle(Message message)
    {
        ValidateSubjectOrderNumber(message);

        base.Handle(message);
    }

    private static void ValidateSubjectOrderNumber(Message message)
    {
        if (!message.Subject.Contains("Nr zam"))
        {
            throw new Exception("Brak numeru zamowienia");
        }
    }
}

// Concrete Handler C
class ValidateAndExtractNipMessageHandler : MessageHandler, IMessageHandler
{
    public override void Handle(Message message)
    {
        // TODO: zwroc nr nip
        ValidateAndExtractNip(message);

        base.Handle(message);
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
}