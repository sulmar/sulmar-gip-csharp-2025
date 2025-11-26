namespace ChainOfResponsibilityPattern;

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
