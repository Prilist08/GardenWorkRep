using GardenERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GardenERP.Application.DTOs.ItemCategory;
namespace GardenERP.Application.Interface
{
    public interface IItemCategoryService
    {
        Task<int> CreateAsync(ItemCategoryDto dto);
        Task<List<ItemCategoryDto>> GetAllAsync();
        Task GetByIdAsync(int id);
    }
}
