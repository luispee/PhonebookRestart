using WhatsAppApiUCU;

namespace Library;

public class WhatsAppChannel : IMessageChannel
{
    WhatsAppApi whatsAppApi = new WhatsAppApi();
    public void Send(Message message)
    {
        string m = whatsAppApi.Send(message.To, message.Text);
    }
    public Message NewMessage(Contact contact, string text)
    {
        WhatsAppMessage message = new WhatsAppMessage(contact);
        message.Text = text;

        return message;
    }
}