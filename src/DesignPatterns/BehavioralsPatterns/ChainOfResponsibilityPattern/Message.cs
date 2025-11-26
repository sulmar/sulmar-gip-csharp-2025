using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern;

internal class Message
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}

class MessageContext
{
    public Message Request { get; set; }
    public MessageResponse Response { get; set; }

    public MessageContext(Message message)
    {
        this.Request = message;

        Response = new MessageResponse();
    }
}

class MessageResponse
{
    public string Nip { get; set; }
    public string Regon { get; set; }
}


class MessageHandlerFactory
{
    public static IMessageHandler Create()
    {
        IMessageHandler root = new ExceptionMessageHandler();

        root
            .SetNext(new ValidateFromWhiteListMessageHandler())
            .SetNext(new ValidateADEMessageHandler())
            .SetNext(new ValidateSubjectOrderNumberMessageHandler())
            .SetNext(new ValidateAndExtractNipMessageHandler());

        return root;
    }    
}

class MessageProcessor
{
    private readonly IMessageHandler chain = null;

    public MessageProcessor(IMessageHandler chain)
    {
        this.chain = chain;
    }

    public string Process(Message message)
    {
        MessageContext context = new MessageContext(message);

        chain.Handle(context);
        
        return context.Response.Nip;
    }
}

// Abstract Handler
interface IMessageHandler
{
    void Handle(MessageContext context);
    IMessageHandler SetNext(IMessageHandler next);
}


// Base Handler
abstract class MessageHandler : IMessageHandler
{
    private IMessageHandler _next;
    public IMessageHandler SetNext(IMessageHandler next)
    {
        _next = next;

        return next;
    }
    public virtual void Handle(MessageContext context)
    {
        if (_next != null)
            _next.Handle(context);
    }
}

// Concrete Handler A
class ValidateFromWhiteListMessageHandler : MessageHandler, IMessageHandler
{
    private string[] whitelist = new string[] { "john@domain.com", "bob@domain.com" };

    public override void Handle(MessageContext context)
    {
        ValidateFromWhiteList(context.Request);

        base.Handle(context);
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
    public override void Handle(MessageContext context)
    {
        ValidateSubjectOrderNumber(context.Request);

        base.Handle(context);
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
    public override void Handle(MessageContext context)
    {
        string nip = ValidateAndExtractNip(context.Request);

        context.Response.Nip = nip;

        base.Handle(context);
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


class ValidateADEMessageHandler : MessageHandler, IMessageHandler
{
    public override void Handle(MessageContext context)
    {
        ValidateADE(context.Request);

        base.Handle(context);
    }

    private void ValidateADE(Message message)
    {
        string pattern = @"AE:PL-\d{5}-\d{5}-[A-Z]{5}-\d{2}";
        Regex regex = new Regex(pattern);

        if (!regex.IsMatch(message.To))
            throw new FormatException("Bledny format ADE");

    }
}

class ExceptionMessageHandler : MessageHandler, IMessageHandler
{
    public override void Handle(MessageContext context)
    {
        try
        {
            base.Handle(context);
        }
        catch(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
        
    }
}