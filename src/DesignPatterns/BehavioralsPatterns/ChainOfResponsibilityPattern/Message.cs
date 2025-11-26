namespace ChainOfResponsibilityPattern;

internal class Message
{
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}

class MessageContext
{
    public Message Request { get; set; }
    public MessageResponse Response { get; set; }

    public MessageContext(Message message)
    {
        this.Request = message;

        Response = new MessageResponse();
    }
}

class MessageResponse
{
    public string Nip { get; set; }
    public string Regon { get; set; }
}
