using System;
using System.Collections;
using System.Collections.Generic;

namespace Day23AddressBook
{

    internal class Program
    {
        string firstName, lastName, address, city, state, zip, phoneNumber, email;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Program p = new Program();
            Dictionary<int, string> addressBook = new Dictionary<int, string>();
            Dictionary<int, string> addressBook2 = new Dictionary<int, string>();


            Choice();
            void Choice()
            {
                Console.WriteLine("\nEnter 1 for Add Details");
                Console.WriteLine("Enter 2 for Add new Details");
                Console.WriteLine("Enter 3 for Edit Details");
                Console.WriteLine("Enter 4 for Delete Details");
                Console.WriteLine("Enter 5 for Add 3rd Person Details");
                Console.WriteLine("Enter 6 for Add new AddressBook Details");
                int value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.WriteLine("Uc 1 Add Details ");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook.Add(0, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook.Add(1, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook.Add(2, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook.Add(3, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook.Add(4, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook.Add(5, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook.Add(6, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook.Add(7, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[0] + "\nLast Name : " + addressBook[1] + "\nAddress : " + addressBook[2] + "\nCity : " + addressBook[3] + "\nState : " + addressBook[4] + "\nZip : " + addressBook[5] + "\nPhone Number : " + addressBook[6] + "\nEmail : " + addressBook[7]);
                        break;
                    case 2:
                        Console.WriteLine("Uc 2 Enter Details");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook.Add(8, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook.Add(9, p.lastName);
                        DuplicateSearch(p.firstName, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook.Add(10, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook.Add(11, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook.Add(12, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook.Add(13, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook.Add(14, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook.Add(15, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[8] + "\nLast Name : " + addressBook[9] + "\nAddress : " + addressBook[10] + "\nCity : " + addressBook[11] + "\nState : " + addressBook[12] + "\nZip : " + addressBook[13] + "\nPhone Number : " + addressBook[14] + "\nEmail : " + addressBook[15]);
                        break;
                    case 3:
                        Console.WriteLine("UC 3 Enter first Name and Last Name of Person to Edit Their Record");
                        string fname = Console.ReadLine();
                        string lname = Console.ReadLine();
                        Check(fname, lname);
                        break;
                    case 4:
                        Console.WriteLine("UC 4 Enter first Name and Last Name of Person to Edit Their Record");
                        string fname1 = Console.ReadLine();
                        string lname1 = Console.ReadLine();
                        Delete(fname1, lname1);
                        break;
                    case 5:
                        Console.WriteLine("UC 5 Add Details ");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook.Add(16, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook.Add(17, p.lastName);
                        DuplicateSearch(p.firstName, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook.Add(18, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook.Add(19, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook.Add(20, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook.Add(21, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook.Add(22, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook.Add(23, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[16] + "\nLast Name : " + addressBook[17] + "\nAddress : " + addressBook[18] + "\nCity : " + addressBook[19] + "\nState : " + addressBook[20] + "\nZip : " + addressBook[21] + "\nPhone Number : " + addressBook[22] + "\nEmail : " + addressBook[23]);
                        break;
                    case 6:
                        Console.WriteLine("Uc 6 new Addres Book ");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook2.Add(0, p.firstName);
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook2.Add(1, p.lastName);
                        DuplicateSearch(p.firstName, p.lastName);
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook2.Add(2, p.address);
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook2.Add(3, p.city);
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook2.Add(4, p.state);
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook2.Add(5, p.zip);
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook2.Add(6, p.phoneNumber);
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook2.Add(7, p.email);
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook2[0] + "\nLast Name : " + addressBook2[1] + "\nAddress : " + addressBook2[2] + "\nCity : " + addressBook2[3] + "\nState : " + addressBook2[4] + "\nZip : " + addressBook2[5] + "\nPhone Number : " + addressBook2[6] + "\nEmail : " + addressBook2[7]);
                        break;

                }
                Choice();
                void Check(string fname, string lname)
                {
                    if (addressBook[0].Equals(fname) && addressBook[1].Equals(lname))
                    {
                        Console.WriteLine("Enter Detail for Updating Details");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook[0] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook[1] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook[2] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook[3] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook[4] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook[5] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook[6] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook[7] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[0] + "\nLast Name : " + addressBook[1] + "\nAddress : " + addressBook[2] + "\nCity : " + addressBook[3] + "\nState : " + addressBook[4] + "\nZip : " + addressBook[5] + "\nPhone Number : " + addressBook[6] + "\nEmail : " + addressBook[7]);

                    }
                    else if (addressBook[8].Equals(fname) && addressBook[9].Equals(lname))
                    {
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook[8] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook[9] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook[10] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook[11] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook[12] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook[13] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook[14] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook[15] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[8] + "\nLast Name : " + addressBook[9] + "\nAddress : " + addressBook[10] + "\nCity : " + addressBook[11] + "\nState : " + addressBook[12] + "\nZip : " + addressBook[13] + "\nPhone Number : " + addressBook[14] + "\nEmail : " + addressBook[15]);

                    }
                    else if (addressBook[16].Equals(fname) && addressBook[17].Equals(lname))
                    {
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook[16] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook[17] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook[18] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook[19] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook[20] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook[21] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook[22] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook[23] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook[16] + "\nLast Name : " + addressBook[17] + "\nAddress : " + addressBook[18] + "\nCity : " + addressBook[19] + "\nState : " + addressBook[20] + "\nZip : " + addressBook[21] + "\nPhone Number : " + addressBook[22] + "\nEmail : " + addressBook[23]);

                    }

                    else if (addressBook2[0].Equals(fname) && addressBook2[1].Equals(lname))
                    {
                        Console.WriteLine("Enter Detail for Updating Details");
                        Console.WriteLine("Enter First Name ");
                        p.firstName = Console.ReadLine();
                        addressBook2[0] = p.firstName;
                        Console.WriteLine("Enter Last Name ");
                        p.lastName = Console.ReadLine();
                        addressBook2[1] = p.lastName;
                        Console.WriteLine("Enter Address ");
                        p.address = Console.ReadLine();
                        addressBook2[2] = p.address;
                        Console.WriteLine("Enter City ");
                        p.city = Console.ReadLine();
                        addressBook2[3] = p.city;
                        Console.WriteLine("Enter State");
                        p.state = Console.ReadLine();
                        addressBook2[4] = p.state;
                        Console.WriteLine("Enter Zip");
                        p.zip = Console.ReadLine();
                        addressBook2[5] = p.zip;
                        Console.WriteLine("Enter Phone Number");
                        p.phoneNumber = Console.ReadLine();
                        addressBook2[6] = p.phoneNumber;
                        Console.WriteLine("Enter Email");
                        p.email = Console.ReadLine();
                        addressBook2[7] = p.email;
                        Console.WriteLine("\nAdded Details are");
                        Console.WriteLine("\nFirst Name : " + addressBook2[0] + "\nLast Name : " + addressBook2[1] + "\nAddress : " + addressBook2[2] + "\nCity : " + addressBook2[3] + "\nState : " + addressBook2[4] + "\nZip : " + addressBook2[5] + "\nPhone Number : " + addressBook2[6] + "\nEmail : " + addressBook2[7]);
                    }
                    else
                    {
                        Console.WriteLine("Search Name is Not in Records");
                    }
                }
                void Delete(string fname1, string lname1)
                {
                    if (addressBook[0].Equals(fname1) && addressBook[1].Equals(lname1))
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            addressBook.Remove(i);

                        }
                        Console.WriteLine("Record Deleted!");
                    }
                    else if (addressBook[8].Equals(fname1) && addressBook[9].Equals(lname1))
                    {
                        for (int i = 8; i < 16; i++)
                        {
                            addressBook.Remove(i);

                        }
                        Console.WriteLine("Record Deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Given Person Details Does Not Exists");
                    }
                }
                void DuplicateSearch(string fname, string lname)
                {
                    if (addressBook[0].Equals(fname) && addressBook[1].Equals(lname))
                    {
                        Console.WriteLine("This Person Record Already Exists");
                    }
                    else if (addressBook[8].Equals(fname) && addressBook[9].Equals(lname))
                    {
                        Console.WriteLine("This Person Record Already Exists");
                    }
                    else if (addressBook[16].Equals(fname) && addressBook[17].Equals(lname))
                    {
                        Console.WriteLine("This Person Record Already Exists");
                    }
                   
                    Choice();

                }

            }

        }
    }

}







