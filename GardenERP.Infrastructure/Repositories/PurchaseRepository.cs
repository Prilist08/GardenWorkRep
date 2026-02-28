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
    public class PurchaseRepository
     : GenericRepository<Purchase>, IPurchaseRepository
    {
        public PurchaseRepository(GardenDbContext context)
            : base(context)
        {
        }
    }
}
