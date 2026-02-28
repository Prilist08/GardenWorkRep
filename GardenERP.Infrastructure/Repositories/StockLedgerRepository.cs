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
    public class StockLedgerRepository
     : GenericRepository<StockLedger>, IStockLedgerRepository
    {
        public StockLedgerRepository(GardenDbContext context)
            : base(context)
        {
        }
    }
}
