using System;
namespace addressbook
{
    internal class program
    {
        public static List<contacts> Person = new List<contacts>();
        


        public static void Main(string[] args)
        {
            addressbook.Person p = new addressbook.Person();


            addressbook.Person.createcontacts();
            addressbook.Person.editcontacts();
            addressbook.Person.deletecontacts();
            p.displaycontacts();
            p.addmulticontacts();
            p.multiaddressbook();
            addressbook.Person.createcontacts();
            p.displaycontacts();
           

        }
    }

}
