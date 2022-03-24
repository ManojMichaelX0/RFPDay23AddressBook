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

            // UC 1 and  UC 2 add Details
            choice();
            void choice()
            {
                Console.WriteLine("\nEnter 1 to Add Details");
                Console.WriteLine("Enter 2 to Add 2nd Person Details");
                a.value = Convert.ToInt32(Console.ReadLine());
                switch (a.value)
                {
                    case 1:

                        Console.WriteLine("Enter First Name ");
                        a.firstName = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName);
                        Console.WriteLine("Enter Last Name");
                        a.lastName = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName);
                        Console.WriteLine("Enter Address ");
                        a.address = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city);
                        Console.WriteLine("Enter state");
                        a.state = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state);
                        Console.WriteLine("Enter zip");
                        a.zip = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo);
                        Console.WriteLine("Enter Email");
                        a.email = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email);

                        Console.WriteLine("\nGiven Detail Are : \n");
                        Console.WriteLine("First Name = " + addbook[0] + "\nLastt Name = " + addbook[1] + "\nAddress = " + addbook[2] + "\nCity = " + addbook[3] + "\nState = " + addbook[4] + "\nZip = " + addbook[5] + "\nPhone Number = " + addbook[6] + "\nEmail = " + addbook[7]);
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name ");
                        a.firstName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName2);
                        Console.WriteLine("Enter Last Name");
                        a.lastName2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName2);
                        Console.WriteLine("Enter Address ");
                        a.address2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address2);
                        Console.WriteLine("Enter city");
                        a.city = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city2);
                        Console.WriteLine("Enter state");
                        a.state2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state2);
                        Console.WriteLine("Enter zip");
                        a.zip2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip2);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo2);
                        Console.WriteLine("Enter Email");
                        a.email2 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email2);

                        Console.WriteLine("\nGiven new Details Are : \n");
                        Console.WriteLine("First Name = " + addbook[8] + "\nLastt Name = " + addbook[9] + "\nAddress = " + addbook[10] + "\nCity = " + addbook[11] + "\nState = " + addbook[12] + "\nZip = " + addbook[13] + "\nPhone Number = " + addbook[14] + "\nEmail = " + addbook[15]);
                        break;

                }
                choice();
            }

        }
    }
}

