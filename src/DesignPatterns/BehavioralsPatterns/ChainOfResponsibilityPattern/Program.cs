// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityPattern;

Console.WriteLine("Hello, World!");


Message message = new Message { From = "john@domain.com", Subject = "Nr zam 1", Body = "Lorem ipsum 953-120-45-91" };

MessageProcessor processor = new MessageProcessor();
var result = processor.Process(message);


Console.WriteLine(result);
