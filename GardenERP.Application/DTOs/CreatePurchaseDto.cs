using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.DTOs
{
    public class CreatePurchaseDto
    {
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime PurchaseDate { get; set; }

        public List<PurchaseItemDto> Items { get; set; }
    }
}
