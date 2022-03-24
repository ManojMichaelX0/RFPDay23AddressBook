using System;
using System.Collections;

namespace Day23AddressBook
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Address a = new Address();
            ArrayList addbook = new ArrayList();
            Console.WriteLine("Enter First Name ");
            a.firstName = Console.ReadLine();
            addbook.Add(a.firstName);

            Console.WriteLine("Enter Last Name");
            a.lastName = Console.ReadLine();
            addbook.Add(a.lastName);

            Console.WriteLine("Enter Address ");
            a.address = Console.ReadLine();
            addbook.Add(a.address);

            Console.WriteLine("Enter city");
            a.city = Console.ReadLine();
            addbook.Add(a.city);

            Console.WriteLine("Enter state");
            a.state = Console.ReadLine();
            addbook.Add(a.state);
            Console.WriteLine("Enter zip");
            a.zip = Console.ReadLine();
            addbook.Add(a.zip);
            Console.WriteLine("Enter Phone Number");
            a.phoneNumber = Convert.ToString(Console.ReadLine());
            addbook.Add(a.phoneNumber);
            Console.WriteLine("Enter Email");
            a.email = Convert.ToString(Console.ReadLine());
            addbook.Add(a.email);

            Console.WriteLine("\nGiven Detail Are : \n");
            Console.WriteLine("First Name = " + addbook[0] + "\nLastt Name = " + addbook[1] + "\nAddress = " + addbook[2] + "\nCity = " + addbook[3] + "\nState = " + addbook[4] + "\nZip = " + addbook[5] + "\nPhone Number = " + addbook[6] + "\nEmail = " + addbook[7]);

            

        }
    }
}

