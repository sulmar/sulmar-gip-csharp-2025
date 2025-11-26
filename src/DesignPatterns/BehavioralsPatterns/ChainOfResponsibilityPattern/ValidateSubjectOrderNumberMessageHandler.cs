namespace ChainOfResponsibilityPattern;

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
