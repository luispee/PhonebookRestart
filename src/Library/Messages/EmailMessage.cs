namespace Library;

public class EmailMessage : Message
{
    public EmailMessage(Contact contact) :
        base("phonebookG6@ucu.edu.uy", contact.Email)
    {

    }
}