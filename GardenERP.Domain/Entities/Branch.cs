using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? GSTNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }

        //public ICollection<ItemCategory> Categories { get; set; }
        //public ICollection<Item> Items { get; set; }
    }
}
