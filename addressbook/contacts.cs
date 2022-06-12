using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    public class contacts
    {
       

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public double phoneNo { get; set; }
        public string email { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is contacts))
            {
                return false;
            }
            return this.firstname == ((contacts)obj).firstname;
        }

        
    }
}
