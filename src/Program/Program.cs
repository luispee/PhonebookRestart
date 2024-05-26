using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact owner = new Contact("Owner");
            owner.Phone = "099123123";
            // Crear la lista de contactos
             Phonebook phonebook= new Phonebook(owner);
            // Agregar contactos a la lista
            string[] list = new string[]{"Seba", "Coty", "Mati", "Luis"};
            Contact luis = new Contact("Luis");
            Contact seba = new Contact("Seba");
            Contact coty = new Contact("Coty");
            Contact mati = new Contact("Mati");

            phonebook.AddContact(luis);
            phonebook.AddContact(seba);
            phonebook.AddContact(coty);
            phonebook.AddContact(mati);

            luis.Phone = "+59899017995";
            seba.Phone = "+59892716220";
            coty.Phone = "+59898529927";
            mati.Phone = "+59898555388";

            luis.Email = "luis@email.com";
            seba.Email = "seba@email.com";
            coty.Email = "coty@email.com";
            mati.Email = "mati@email.com";
            // Enviar un correo a algunos contactos
            EmailChannel emailChannel = new EmailChannel();
            phonebook.SendMessage(list, "Enviado desde Phonebook P2", emailChannel);
            // Enviar un WhatsApp a algunos contactos
            /* WhatsAppChannel whatsAppChannel= new WhatsAppChannel();
            phonebook.SendMessage(list, "Enviado desde Phonebook P2", whatsAppChannel); */
            // Enviar un SMS a algunos contactos
            SMSChannel SMSChannel = new SMSChannel();
            phonebook.SendMessage(list, "Enviado desde Phonebook", SMSChannel);
        }
    }
}
