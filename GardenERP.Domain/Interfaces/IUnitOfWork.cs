using GardenERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Branch> Branches { get; }
        IGenericRepository<ItemCategory> ItemCategories { get; }
        IGenericRepository<Item> Items { get; }
        IGenericRepository<Supplier> Suppliers { get; }


        IPurchaseRepository Purchases { get; }
        IPurchaseDetailRepository PurchaseDetails { get; }
        IStockLedgerRepository StockLedgers { get; }

        Task<int> SaveChangesAsync();
    }
}
