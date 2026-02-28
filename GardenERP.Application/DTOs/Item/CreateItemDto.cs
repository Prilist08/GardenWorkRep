using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.DTOs.Item
{
    public class CreateItemDto
    {
        public int BranchId { get; set; }
        public int? CategoryId { get; set; }
        public string ItemName { get; set; }
        public string? Unit { get; set; }
        public int MinStockLevel { get; set; }
    }
}
