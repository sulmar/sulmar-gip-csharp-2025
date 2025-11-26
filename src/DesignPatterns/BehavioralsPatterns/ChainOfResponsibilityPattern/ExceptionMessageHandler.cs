namespace ChainOfResponsibilityPattern;

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