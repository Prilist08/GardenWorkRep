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
    public class SupplierRepository : ISupplierRepository
    {
        public Task AddAsync(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Supplier>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Supplier?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
