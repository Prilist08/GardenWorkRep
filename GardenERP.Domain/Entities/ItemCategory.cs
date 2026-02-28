using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Entities
{
    public class ItemCategory
    {
        public int ItemCategoryId { get; set; }
        public int BranchId { get; set; }
        public string CategoryName { get; set; }

        public Branch Branch { get; set; }
    }
}
