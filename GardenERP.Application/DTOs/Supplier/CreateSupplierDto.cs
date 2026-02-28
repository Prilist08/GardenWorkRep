using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.DTOs.Supplier
{
    public class CreateSupplierDto
    {
        public int BranchId { get; set; }
        public string SupplierName { get; set; }
        public string? Mobile { get; set; }
        public string? GSTNumber { get; set; }
    }
}
