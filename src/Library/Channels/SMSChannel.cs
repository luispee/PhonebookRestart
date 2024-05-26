using System;

namespace Library;

public class SMSChannel : IMessageChannel
{
    public void Send(Message message)
    {
        Console.WriteLine($"Mensaje enviado a través de SMS a {message.To}");  
    }
    public Message NewMessage(Contact contact, string text)
    {
        SMSMessage message = new SMSMessage(contact);
        message.Text = text;

        return message;
    }
}