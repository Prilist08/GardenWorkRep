using GardenERP.Application.DTOs.ItemCategory;
using GardenERP.Application.Interface;
using GardenERP.Domain.Entities;
using GardenERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GardenERP.Application.Services
{
    public class ItemCategoryService : IItemCategoryService
    {
        private readonly IItemCategoryRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ItemCategoryService(IItemCategoryRepository repository,
                            IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task<int> CreateAsync(ItemCategoryDto dto)
        {
            var branch = new ItemCategory
            {

                CategoryName = dto.CategoryName,
                BranchId = dto.BranchId
                
            };

            await _repository.AddAsync(branch);
            await _unitOfWork.SaveChangesAsync();

            return branch.ItemCategoryId;
        }
        public async Task<List<ItemCategoryDto>> GetAllAsync()
        {
            var branches = await _repository.GetAllAsync();

            return branches.Select(b => new ItemCategoryDto
            {
                CategoryName = b.CategoryName,
               // CategoryId= b.CategoryId,
                BranchId= b.BranchId
                
            }).ToList();
        }

        public Task GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
