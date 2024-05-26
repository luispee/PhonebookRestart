namespace Library;

public interface IMessageChannel
{
        void Send(Message message);
        Message NewMessage(Contact contact, string text);
}