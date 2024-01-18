using AddressBookProject;
using System;
namespace Demo
{
    class AddressBookMain
    {
        

        static void Main(string[] args)
        {
           
            //use Case1
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Enter Firstname");
            string first = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string last = Console.ReadLine();

            Console.WriteLine("Enter the address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city name");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state name");
            string state = Console.ReadLine();

            Console.WriteLine("Enter zip code");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter phone number");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter email id");
            string email = Console.ReadLine();

            //Use Case2
            Contact newContact1 = new Contact(first, last, address, city, state, zip, phone, email);
            Contact newContact2 = new Contact(first, last, address, city, state, zip, phone, email);
            addressBook.AddContact(newContact1);
            addressBook.AddContact(newContact2);


            //Use case3
            Console.WriteLine("Enter the Firstname of the contact to edit:");
            string editFirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the contact to edit:");
            string editLastName = Console.ReadLine();

            addressBook.EditContact(editFirstName, editLastName);

            //Use Case4

            Console.WriteLine("Enter the Firstname of the contact to delete:");
            string deleteFirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the contact to delete:");
            string deleteLastName = Console.ReadLine();

            addressBook.DeleteContact(deleteFirstName, deleteLastName);



            addressBook.DisplayContacts();
        }

        
    }

}
