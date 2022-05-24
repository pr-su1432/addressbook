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
    }
}

