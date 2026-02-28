using GardenERP.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.Interface
{
    public interface IPurchaseService
    {
        Task<int> CreateAsync(CreatePurchaseDto dto);
    }
}
