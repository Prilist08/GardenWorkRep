using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Entities
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int BranchId { get; set; }
        public int SupplierId { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime PurchaseDate { get; set; }

        public decimal SubTotal { get; set; }
        public decimal GSTAmount { get; set; }
        public decimal TotalAmount { get; set; }

        public Branch Branch { get; set; }
        public Supplier Supplier { get; set; }

        public ICollection<PurchaseDetail> Details { get; set; }
    }
}
