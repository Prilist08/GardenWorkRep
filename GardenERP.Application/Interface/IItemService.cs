using GardenERP.Application.DTOs.Item;
using GardenERP.Application.DTOs.ItemCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenERP.Application.Interface
{
    public interface IItemService
    {
        Task<int> CreateAsync(ItemCategoryDto dto);
        Task<List<ItemCategoryDto>> GetAllAsync();
        Task GetByIdAsync(int id);
    }
}
