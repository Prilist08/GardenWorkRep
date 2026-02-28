using GardenERP.Application.Interface;
using GardenERP.Domain.Entities;
using GardenERP.Domain.Interfaces;
using GardenERP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Infrastructure.Repositories
{
    public class BranchRepository
     : GenericRepository<Branch>, IBranchRepository
    {
        public BranchRepository(GardenDbContext context)
            : base(context)
        {
        }
    }
}
