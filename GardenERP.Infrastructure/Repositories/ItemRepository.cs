using GardenERP.Application.Interface;
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
    public class ItemRepository : IItemRepository
    {
        private readonly GardenDbContext _context;

        public ItemRepository(GardenDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetByBranchAsync(int branchId)
        {
            throw new NotImplementedException();
        }

        public Task<Item?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Item entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
