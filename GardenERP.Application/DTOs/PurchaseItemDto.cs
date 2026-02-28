using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.DTOs
{
    public class PurchaseItemDto
    {
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}
