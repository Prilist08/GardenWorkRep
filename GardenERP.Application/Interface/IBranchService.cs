using GardenERP.Application.DTOs;
using GardenERP.Application.DTOs.branch;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenERP.Application.DTOs.branch;
namespace GardenERP.Application.Interface
{
    public interface IBranchService
    {
        Task<int> CreateAsync(CreateBranchDto dto);
        Task<List<DTOs.branch.BranchResponseDto>> GetAllAsync();
        Task<DTOs.branch.BranchResponseDto> GetByIdAsync(int id);
        Task UpdateAsync(int id, UpdateBranchDto dto);
        Task DeleteAsync(int id);
    }
}
