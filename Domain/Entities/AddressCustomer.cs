using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AddressCustomer : BaseEntity
    {
        public int CustomerId { get; set; }      //Foreign key
        public Customer Customers { get; set; } /* One-to-one Customer Relational Line where each CustomerAddress will have a single Customer type data */
        public string RouteType { get; set; }
        public int PriNumber { get; set; }
        public string Letter { get; set; }
        public string Bis { get; set; }
        public string SecLetter { get; set; }
        public string Cardinal { get; set; }
        public int SecNumber { get; set; }
        public string LetterTer { get; set; }
        public int TerNumber { get; set; }
        public string CardinalSec { get; set; }
        public string Complement { get; set; }
        public string PostCode { get; set; }
        public int CityId { get; set; }
        public City Cities { get; set; }
    }
}