using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Entities
{
    public class StockLedger
    {
        public int StockLedgerId { get; set; }
        public int BranchId { get; set; }
        public int ItemId { get; set; }

        public int? RefId { get; set; }
        public string? RefType { get; set; }

        public decimal QuantityIn { get; set; }
        public decimal QuantityOut { get; set; }

        public DateTime TransactionDate { get; set; }

        public Branch Branch { get; set; }
        public Item Item { get; set; }
    }
}
