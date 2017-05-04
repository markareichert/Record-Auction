using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordAuction.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
        public string Country { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
    }
}
