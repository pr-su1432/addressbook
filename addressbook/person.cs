using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    internal class Person
    {
        public static List<contacts> person = new List<contacts>();
        public Dictionary<string, List<contacts>> group = new Dictionary<string, List<contacts>>();
        

        public static void createcontacts()
        {

            contacts contact = new contacts();
            Console.WriteLine("Enter First Name: ");
            contact.firstname = Console.ReadLine();
            contacts contacts = person.FirstOrDefault(p => p.Equals(contact));
            if (contacts == null)
            {
                Console.WriteLine("Enter Last Name: ");
                contact.lastname = Console.ReadLine();

                Console.WriteLine("Enter Phone Number: ");
                contact.phoneNo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Address: ");
                contact.address = Console.ReadLine();

                Console.WriteLine("Enter City: ");
                contact.city = Console.ReadLine();

                Console.WriteLine("Enter Zip: ");
                contact.zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter State: ");
                contact.state = Console.ReadLine();

                Console.WriteLine("Enter Email: ");
                contact.email = Console.ReadLine();

                person.Add(contact);
            }
            else
                Console.WriteLine("Contact already exist in address book.\n");

        }

        public void displaycontacts()
        {
            if (program.Person.Count == 0)
            {
                Console.WriteLine("address book is empty.");
                return;
            }
            Console.WriteLine("list of contacts:\n");
            foreach (var contact in program.Person)
            {
                Console.WriteLine("first name: " + contact.firstname);
                Console.WriteLine("last name: " + contact.lastname);
                Console.WriteLine("address: " + contact.address);
                Console.WriteLine("city: " + contact.city);
                Console.WriteLine("state: " + contact.state);
                Console.WriteLine("zip Code: " + contact.zip);
                Console.WriteLine("contact No: " + contact.phoneNo);
                Console.WriteLine("email address: " + contact.email);
            }

        }
        public static void editcontacts()
        {
            Console.WriteLine("Enter Name of person to edit details: ");
            string name = Console.ReadLine();

            foreach (var contact in program.Person)
            {
                if (contact.firstname.Equals(name))
                {
                    Console.WriteLine("which field you want to edit:\n1.full name\n2.last name\n3.address\n4.city\n5.state\n6.zip\n7.phoneNo\n8.email\n");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first name to update:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter last name to update:");
                            contact.lastname = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter address to update:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter city to update:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter state to update:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter phone No to update:");
                            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter email to update:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter first name to update:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }
            }
        }
        public static void deletecontacts()
        {
            Console.WriteLine("Enter the Name of person to delete details: ");
            string inp_name = Console.ReadLine();

            foreach (var contact in program.Person)
            {
                if (contact.firstname.Equals(inp_name))
                {
                    Console.WriteLine("which field you want to edit:\n1.full name\n2.last name\n3.address\n4.city\n5.state\n6.zip\n7.phoneNo\n8.email\n");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first name to delete:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter last name to delete:");
                            contact.lastname = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter address to delete:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter city to delete:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter state to delete:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter phone No to delete:");
                            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter email to delete:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter first name to delete:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }

            }
        }
        public void addmulticontacts()
        {
            Console.WriteLine("How many contacts you want to add: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                createcontacts();
                n--;
            }
        }
        public void multiaddressbook()
        {
            Dictionary<string, List<contacts>> group = new Dictionary<string, List<contacts>>();
            Console.WriteLine("Howmany number of address books you want to add? ");
            int numberofbooks = Convert.ToInt32(Console.ReadLine());
            while (numberofbooks > 0)
            {
                Console.WriteLine("Enter name of the owner of this address book: ");
                string gname = Console.ReadLine();
                Person person = new Person();
                person.addmulticontacts();
                group.Add(gname, program.Person);
                numberofbooks--;
            }
        }
    }
}

      