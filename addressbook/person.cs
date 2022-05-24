using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    internal class person
    {
        public static void createcontacts()
        {
            contacts contact = new contacts();
            Console.WriteLine("Enter first name: ");
            contact.firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname name: ");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter phone Number: ");
            contact.phoneNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter city: ");
            contact.city = Console.ReadLine();


            Console.WriteLine("Enter zip: ");
            contact.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter state: ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            contact.email = Console.ReadLine();

            program.person.Add(contact);
        }
        public static void displaycontacts()
        {
            if (program.person.Count == 0)
            {
                Console.WriteLine("address book is empty.");
                return;
            }
            Console.WriteLine("list of contacts:\n");
            foreach (var contact in program.person)
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

            foreach (var contact in program.person)
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
    }
}

