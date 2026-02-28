using GardenERP.Application.DTOs.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.Interface
{
    public interface ISupplierService
    {
        Task<int> CreateAsync(CreateSupplierDto dto);
    }
}
