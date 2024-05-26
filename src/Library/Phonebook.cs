using System.Collections.Generic;

namespace Library;

public class Phonebook
{
    private List<Contact> persons;

    public Phonebook(Contact owner)
    {
        this.Owner = owner;
        this.persons = new List<Contact>();
    }

    public Contact Owner { get; }

    public List<Contact> Search(string[] names)
    {
        List<Contact> result = new List<Contact>();

        foreach (Contact person in this.persons)
        {
            foreach (string name in names)
            {
                if (person.Name.Equals(name))
                {
                    result.Add(person);
                }
            }
        }

        return result;
    }
    public void AddContact(Contact contact)
    {
        persons.Add(contact);
    }
    public void RemoveContact(Contact contact)
    {
        persons.Remove(contact);
    }
    public void SendMessage(string[] names, string text, IMessageChannel channel)
    {
        List<Contact> contacts = Search(names);
        foreach (Contact contact in contacts)
        {
            Message outgoingMessage = channel.NewMessage(contact, text);
            channel.Send(outgoingMessage);
        }
    }
}