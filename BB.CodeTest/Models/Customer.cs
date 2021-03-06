using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BB.CodeTest.Models.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
