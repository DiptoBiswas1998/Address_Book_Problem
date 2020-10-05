using System;
using System.Collections.Generic;
using System.Text;
namespace Address_Book_Problem
{
    class TakeInfo
    {
        public static void TakingInfo()
        {
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
            Console.WriteLine("Press 1 to Edit\nAny other digit to abort");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                addressBook.EditContact(firstName);
                addressBook.ViewContact();
            }
        }
    }
}
