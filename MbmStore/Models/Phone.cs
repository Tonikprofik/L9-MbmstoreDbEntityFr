using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }
        public int CustomerID { get; set; }
        public enum PhoneTypes 
        {    
            Mobile=0,
            Home=1, 
            Work=2, 
            Other=3
        }
        public Customer Customer { get; set; }

    }
}
