using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    class AddressBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DisplayContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}, Phone: {contact.PhoneNumber}");
            }
        }
        public Contact FindContactByName(string firstName, string lastName)
        {
            return contacts.Find(contact => contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
        public void DeleteContact(string firstName, string lastName)
        {
            Contact contactToDelete = FindContactByName(firstName, lastName);

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine($"Contact {contactToDelete.FirstName} {contactToDelete.LastName} deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
        

        public void EditContact(string firstName, string lastName)
        {
            Contact existingContact = FindContactByName(firstName, lastName);

            if (existingContact != null)
            {
                Console.WriteLine($"Editing contact: {existingContact.FirstName} {existingContact.LastName}");

                Console.WriteLine("Enter new Firstname");
                existingContact.FirstName = Console.ReadLine();

                Console.WriteLine("Enter new last name");
                existingContact.LastName = Console.ReadLine();

                Console.WriteLine("Enter new address");
                existingContact.Address = Console.ReadLine();

                Console.WriteLine("Enter new city name");
                existingContact.City = Console.ReadLine();

                Console.WriteLine("Enter new state name");
                existingContact.State = Console.ReadLine();

                Console.WriteLine("Enter new zip code");
                existingContact.Zip = Console.ReadLine();

                Console.WriteLine("Enter new phone number");
                existingContact.PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter new email id");
                existingContact.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

    }
}
