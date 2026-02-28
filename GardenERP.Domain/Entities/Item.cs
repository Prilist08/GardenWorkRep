using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public int BranchId { get; set; }
        public int? CategoryId { get; set; }
        public string ItemName { get; set; }
        public string? Unit { get; set; }
        public int MinStockLevel { get; set; }
        public bool IsActive { get; set; }

        public Branch Branch { get; set; }
        public ItemCategory Category { get; set; }
    }
}
