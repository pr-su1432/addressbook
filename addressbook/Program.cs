﻿using System;
namespace addressbook
{
    public class program
    {

       public static List<contacts> person = new List<contacts>();


        public static void Main(string[] args)
        {
            Person p = new Person();


           // p.createcontacts();
           // p.editcontacts();
           // p.deletecontacts();
           // p.displaycontacts();
           // p.addmulticontacts();
            p.multiaddressbook();
            p.createcontacts();
            p.SearchByCityorState();
            p.displaycontacts();





        }
    }

}
