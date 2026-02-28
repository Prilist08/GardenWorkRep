using GardenERP.Application.DTOs.Item;
using GardenERP.Application.DTOs.ItemCategory;
using GardenERP.Application.Interface;
using GardenERP.Domain.Entities;
using GardenERP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IItemRepository = GardenERP.Domain.Interfaces.IItemRepository;

namespace GardenERP.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;
        
        private readonly IUnitOfWork _unitOfWork;
        public ItemService(IItemRepository repository,IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public Task<int> CreateAsync(CreateItemDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(ItemCategoryDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemCategoryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CreateItemDto>> GetByBranchAsync(int branchId)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
