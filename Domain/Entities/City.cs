using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
        public AddressCustomer AddressCustomers { get; set; }

    }
}