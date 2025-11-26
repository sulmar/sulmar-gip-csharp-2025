namespace ChainOfResponsibilityPattern;

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
