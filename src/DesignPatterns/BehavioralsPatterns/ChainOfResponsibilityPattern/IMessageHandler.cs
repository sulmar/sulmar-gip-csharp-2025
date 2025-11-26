namespace ChainOfResponsibilityPattern;

// Abstract Handler
interface IMessageHandler
{
    void Handle(MessageContext context);
    IMessageHandler SetNext(IMessageHandler next);
}
