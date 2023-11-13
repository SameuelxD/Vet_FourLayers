using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public int PetId { get; set; }
        public Pet Pets { get; set; }
        public int ServiceId { get; set; }
        public Service Services { get; set; }
    }
}