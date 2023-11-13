using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TelephoneCustomer:BaseEntity
    {
        public int CustomerId { get; set; } 
        public Customer Customers { get; set; } /* One-to-one Client Relational Line where each Telephone Client will have a single Client type data */
        public string Number { get; set; }
    }
}