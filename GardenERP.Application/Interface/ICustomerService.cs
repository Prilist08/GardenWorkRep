using GardenERP.Application.DTOs.branch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.Interface
{
    public interface ICustomerService
    {
        Task<int> CreateAsync(DTOs.Customer.CreateUpdateCustomerDto dto);
        Task<List<DTOs.Customer.ResponseCustomerDto>> GetAllAsync();
        Task<DTOs.Customer.ResponseCustomerDto> GetByIdAsync(int id);
        Task UpdateAsync(int id, DTOs.Customer.CreateUpdateCustomerDto dto);
        Task DeleteAsync(int id);
    }
}
