using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern;

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
