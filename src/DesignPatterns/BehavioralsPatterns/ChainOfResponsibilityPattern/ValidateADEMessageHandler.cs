using System.Text.RegularExpressions;

namespace ChainOfResponsibilityPattern;

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
