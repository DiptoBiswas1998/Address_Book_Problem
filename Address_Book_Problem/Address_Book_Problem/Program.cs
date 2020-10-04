using System;

namespace Address_Book_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program.");
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("Enter first Name: ");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter last Name: ");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            String address = Console.ReadLine();
            Console.WriteLine("Enter city: ");
            String city = Console.ReadLine();
            Console.WriteLine("Enter state: ");
            String state = Console.ReadLine();
            Console.WriteLine("Enter zip: ");
            String zip = Console.ReadLine();
            Console.WriteLine("Enter phNo: ");
            String phNo = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            String email = Console.ReadLine();
            addressBook.AddContact(firstName, lastName, address, city, state, zip, phNo, email);
            addressBook.ViewContact();
        }
    }
}
