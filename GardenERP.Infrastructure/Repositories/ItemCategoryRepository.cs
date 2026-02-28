using GardenERP.Application.Interface;
using GardenERP.Domain.Entities;
using GardenERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Infrastructure.Repositories
{
    public class ItemCategoryRepository : IItemCategoryRepository
    {
        public Task AddAsync(ItemCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemCategory>> GetByBranchAsync(int branchId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemCategory>> GetByCategoryAsync(int branchId)
        {
            throw new NotImplementedException();
        }

        public Task<ItemCategory?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ItemCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ItemCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
