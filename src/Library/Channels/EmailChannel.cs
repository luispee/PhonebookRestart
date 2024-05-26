using System;

namespace Library;

public class EmailChannel : IMessageChannel
{
    public void Send(Message message)
    {
        Console.WriteLine($"Email enviado satisfactorimente a {message.To}");    
    }
    public Message NewMessage(Contact contact, string text)
    {
        EmailMessage message = new EmailMessage(contact);
        message.Text = text;

        return message;
    }
}