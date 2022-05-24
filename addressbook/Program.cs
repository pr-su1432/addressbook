// See https://aka.ms/new-console-template for more information
using addressbook;
internal class program
{
    public static List<contacts> person = new List<contacts>();

    public static void Main(string[] args)
    {
        addressbook.person.createcontacts();
        addressbook.person.displaycontacts();
        addressbook.person.editcontacts();
        addressbook.person.deletecontacts();
    }
}
