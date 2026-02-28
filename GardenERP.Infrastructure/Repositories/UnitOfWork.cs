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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GardenDbContext _context;

        public IGenericRepository<Branch> Branches { get; }
        public IGenericRepository<ItemCategory> ItemCategories { get; }
        public IGenericRepository<Item> Items { get; }
        public IGenericRepository<Supplier> Suppliers { get; }

        public IPurchaseRepository Purchases { get; }
        public IPurchaseDetailRepository PurchaseDetails { get; }
        public IStockLedgerRepository StockLedgers { get; }

        public UnitOfWork(GardenDbContext context)
        {
            _context = context;

            Branches = new GenericRepository<Branch>(context);
            ItemCategories = new GenericRepository<ItemCategory>(context);
            Items = new GenericRepository<Item>(context);
            Suppliers = new GenericRepository<Supplier>(context);

            Purchases = new PurchaseRepository(context);
            PurchaseDetails = new PurchaseDetailRepository(context);
            StockLedgers = new StockLedgerRepository(context);
        }

        public async Task<int> SaveChangesAsync()
            => await _context.SaveChangesAsync();

        public void Dispose()
            => _context.Dispose();
    }
}
