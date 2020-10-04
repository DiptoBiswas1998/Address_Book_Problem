using System;

namespace Address_Book_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Problem!");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Dipto", "Biswas", "Rahara, Khardah", "Kolkata", "West Bengal", "700118", "9876543210", "diptobiswas@gmail.com");
            addressBook.ViewContact();
        }
    }
}
