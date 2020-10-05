using System;
using System.Collections.Generic;
using System.Text;
namespace Address_Book_Problem
{
    class AddressBook
    {
        private Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();
        public void AddContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Address = address;
            contact.City = city;
            contact.State = state;     
            contact.Zip = zip;
            contact.PhoneNumber = phoneNumber;
            contact.Email = email;
            addressBook.Add(contact.FirstName, contact);
        }
        public void ViewContact()
        {
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                Console.WriteLine("First Name: " + item.Value.FirstName);
                Console.WriteLine("Last Name: " + item.Value.LastName);
                Console.WriteLine("Address: " + item.Value.Address);
                Console.WriteLine("City: " + item.Value.City);
                Console.WriteLine("State: " + item.Value.State);             
                Console.WriteLine("Zip: " + item.Value.Zip);
                Console.WriteLine("Phone Number: " + item.Value.PhoneNumber);
                Console.WriteLine("Email: " + item.Value.Email);
            }
        }
        public void EditContact(string name)
        {
            foreach (KeyValuePair<string, Contact> item in addressBook)
            {
                if(item.Key.Equals(name))
                {
                    TakeInfo TakingInfo = new TakeInfo();
                    TakeInfo.TakingInfo();
                }
            }
        }
        public void DeleteContact(string name)
        {
            if (addressBook.ContainsKey(name))
            {
                addressBook.Remove(name);
                Console.WriteLine("Contact successfully deleted!");
            }
        }
    }
}
