using GardenERP.Domain.Entities;
using GardenERP.Domain.Interfaces;
using GardenERP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Infrastructure.Repositories
{
    public class PurchaseDetailRepository
     : GenericRepository<PurchaseDetail>, IPurchaseDetailRepository
    {
        public PurchaseDetailRepository(GardenDbContext context)
            : base(context)
        {
        }
    }
}
