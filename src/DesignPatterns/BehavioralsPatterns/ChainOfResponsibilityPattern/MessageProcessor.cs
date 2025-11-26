namespace ChainOfResponsibilityPattern;

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
