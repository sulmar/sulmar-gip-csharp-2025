namespace ChainOfResponsibilityPattern;

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
    
    public static IMessageHandler Create(params IMessageHandler[] handlers)
    {
        foreach(var (current, next) in handlers.Zip(handlers.Skip(1)))
        {
            current.SetNext(next);
        }

        return handlers[0];
    }
}
