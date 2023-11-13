using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pet:BaseEntity
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int BreedId { get; set; }

        public Breed Breeds { get; set; }

        public DateTime BirthDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
