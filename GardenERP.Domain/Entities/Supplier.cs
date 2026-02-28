using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public int BranchId { get; set; }
        public string SupplierName { get; set; }
        public string? Address { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? GSTNumber { get; set; }

        public Branch Branch { get; set; }
    }
}
