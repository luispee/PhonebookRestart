namespace Library;

public class SMSMessage : Message
{
    public SMSMessage(Contact contact) :
        base("Phonebook", contact.Phone)
        {
            //No puedo asignarle atributos porque Message es protected, es por eso que uso base y el primer argumento es From y el segundo To
            //this.From = "Phonebook";
        }
}