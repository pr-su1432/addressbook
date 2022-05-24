// See https://aka.ms/new-console-template for more information
using addressbook;
internal class program
{
    public static List<contacts> person = new List<contacts>();

    public static void main(string[] args)
    {
        addressbook.person.creatcontact();
        addressbook.person.displaycontacts();
        addressbook.person.editcontacts();
    }
}
