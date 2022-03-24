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

             
            choice();
            void choice()
            {
                Console.WriteLine("\nEnter 1 to Add Details");
                Console.WriteLine("Enter 2 to Add 2nd Person Details");
                Console.WriteLine("Enter 3 to Edit Existing Detail");
                Console.WriteLine("Enter 4 to Delete Existing Detials");
                Console.WriteLine("Enter 5 to Add 3rd Person Details");
                a.value = Convert.ToInt32(Console.ReadLine());
                switch (a.value)
                {
                    //UC 1
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
                        //UC 2
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
                        //UC 3
                    case 3:
                        Console.WriteLine("Enter the First Name and Last Name of that Person");
                        string fname = Convert.ToString(Console.ReadLine());
                        string lname = Convert.ToString(Console.ReadLine());

                        if ((a.firstName == fname) && (a.lastName == lname))
                        {
                            Console.WriteLine("Editing Record For New Details" + "\nEnter First Name ");
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
                            Console.WriteLine("\nDetails After Editing Are : \n");
                            Console.WriteLine("First Name = " + addbook[0] + "\nLastt Name = " + addbook[1] + "\nAddress = " + addbook[2] + "\nCity = " + addbook[3] + "\nState = " + addbook[4] + "\nZip = " + addbook[5] + "\nPhone Number = " + addbook[6] + "\nEmail = " + addbook[7]);
                           
                        }
                        else if ((a.firstName2 == fname) && (a.lastName2 == lname))
                        {
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

                            Console.WriteLine("\nDetails After Editing Are : \n");
                            Console.WriteLine("First Name = " + addbook[8] + "\nLastt Name = " + addbook[9] + "\nAddress = " + addbook[10] + "\nCity = " + addbook[11] + "\nState = " + addbook[12] + "\nZip = " + addbook[13] + "\nPhone Number = " + addbook[14] + "\nEmail = " + addbook[15]);
                        }
                        else if ((a.firstName3 == fname) && (a.lastName3 == lname))
                        {
                            Console.WriteLine("Enter First Name ");
                            a.firstName3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.firstName3);
                            Console.WriteLine("Enter Last Name");
                            a.lastName3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.lastName3);
                            Console.WriteLine("Enter Address ");
                            a.address3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.address3);
                            Console.WriteLine("Enter city");
                            a.city3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.city3);
                            Console.WriteLine("Enter state");
                            a.state3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.state3);
                            Console.WriteLine("Enter zip");
                            a.zip3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.zip3);
                            Console.WriteLine("Enter Phone Number");
                            a.phoneNo3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.phoneNo3);
                            Console.WriteLine("Enter Email");
                            a.email3 = Convert.ToString(Console.ReadLine());
                            addbook.Add(a.email3);

                            Console.WriteLine("\nDetails After Editing Are : \n");
                            Console.WriteLine("First Name = " + addbook[16] + "\nLastt Name = " + addbook[17] + "\nAddress = " + addbook[18] + "\nCity = " + addbook[19] + "\nState = " + addbook[20] + "\nZip = " + addbook[21] + "\nPhone Number = " + addbook[22] + "\nEmail = " + addbook[23]);
                        }
                        break;
                        //UC 4
                    case 4:
                        Console.WriteLine("Enter First Name and Last Name of the person to delete his record");
                        string fname1 = Convert.ToString(Console.ReadLine());
                        string lname2 = Convert.ToString(Console.ReadLine());
                        if ((a.firstName == fname1) && (a.lastName == lname2))
                        {
                            //Removing Details for that Person
                            addbook.RemoveRange(0, 7);

                            Console.WriteLine("\n Record Deleted \n");

                        }
                        else if ((a.firstName2 == fname1) && (a.lastName2 == lname2))
                        {
                            //Removing Details for that Person
                            addbook.RemoveRange(8, 15);
                            Console.WriteLine("\n Record Deleted \n");

                        }
                        else if ((a.firstName3 == fname1) && (a.lastName3 == lname2))
                        {
                            //Removing Detail for that Person
                            addbook.RemoveRange(16, 23);
                            Console.WriteLine("\n Record Deleted \n");
                        }
                        break;
                        //UC 5
                    case 5:

                        Console.WriteLine("Enter First Name ");
                        a.firstName3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.firstName3);
                        Console.WriteLine("Enter Last Name");
                        a.lastName3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.lastName3);
                        Console.WriteLine("Enter Address ");
                        a.address3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.address3);
                        Console.WriteLine("Enter city");
                        a.city3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.city3);
                        Console.WriteLine("Enter state");
                        a.state3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.state3);
                        Console.WriteLine("Enter zip");
                        a.zip3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.zip3);
                        Console.WriteLine("Enter Phone Number");
                        a.phoneNo3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.phoneNo3);
                        Console.WriteLine("Enter Email");
                        a.email3 = Convert.ToString(Console.ReadLine());
                        addbook.Add(a.email3);

                        Console.WriteLine("\nGiven Detail Are : \n");
                        Console.WriteLine("First Name = " + addbook[16]+"Lastt Name = " + addbook[17]+"Address = " + addbook[18]+"City = " + addbook[19]+"State = " + addbook[20]+"Zip = " + addbook[21]+"Phone Number = " + addbook[22]+"Email = " + addbook[23]);
                        break;
                }
                choice();
            }

        }
    }
}





