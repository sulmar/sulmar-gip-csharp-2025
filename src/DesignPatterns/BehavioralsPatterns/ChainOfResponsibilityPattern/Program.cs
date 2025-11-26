// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityPattern;

Console.WriteLine("Hello, World!");

Message message = new Message { From = "john@domain.com", To = "AE:PL-00000-11111-YYYYY-22", Subject = "Nr zam 1", Body = "Lorem ipsum 953-120-45-91" };

IMessageHandler chain = MessageHandlerFactory.Create(
    new ExceptionMessageHandler(),
    new ValidateFromWhiteListMessageHandler(),
    new ValidateADEMessageHandler(),
    new ValidateSubjectOrderNumberMessageHandler(),
    new ValidateAndExtractNipMessageHandler()
    );

MessageProcessor processor = new MessageProcessor(chain);
var result = processor.Process(message);


Console.WriteLine(result);


var context = new MessageContext(new Message { To = "AE:PL-00000-11111-YYYYY-22" });
ValidateADEMessageHandler handler = new ValidateADEMessageHandler();
handler.Handle(context);
