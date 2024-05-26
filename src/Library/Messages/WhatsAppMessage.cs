namespace Library;

public class WhatsAppMessage : Message
{
    public WhatsAppMessage(Contact contact) :
        base("Phonebook", contact.Phone)
        {
            //No puedo asignarle atributos porque es protected, es por eso que uso base y el primer argumento es From y el segundo To
            //this.From = "Phonebook";
        }
}