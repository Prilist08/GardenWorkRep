using GardenERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.DTOs.Customer
{
    public class ResponseCustomerDto
    {
        public int CustomerId { get; set; }

        public string FullName { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
