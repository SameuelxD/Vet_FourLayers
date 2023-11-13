using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public AddressCustomer AddressCustomers { get; set; }

        /* Client Relational Line Address one by one where each Client will have a single ClientAddress type data */

        public ICollection<TelephoneCustomer> TelephoneCustomers { get; set; }

        /* One-to-one Telephone Client Relational Line where each Client will have a single Telephone Client type data */

        public ICollection<Pet> Pets { get; set; }
        /* One-to-many Pet Relational Line where each Client will have a Pet type data group */

        public ICollection<Appointment> Appointments { get; set; }

    }
}