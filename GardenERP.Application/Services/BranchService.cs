using GardenERP.Application.DTOs;
using GardenERP.Application.DTOs.branch;
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
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public BranchService(IBranchRepository repository,
                             IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> CreateAsync(DTOs.branch.CreateBranchDto dto)
        {
            var branch = new Branch
            {
                BranchName = dto.BranchName,
                City = dto.City,
                State = dto.State
            };

            await _repository.AddAsync(branch);
            await _unitOfWork.SaveChangesAsync();

            return branch.BranchId;
        }

        public async Task<List<DTOs.branch.BranchResponseDto>> GetAllAsync()
        {
            var branches = await _repository.GetAllAsync();

            return branches.Select(b => new DTOs.branch.BranchResponseDto
            {
                BranchId = b.BranchId,
                BranchName = b.BranchName,
                City = b.City,
                State = b.State
            }).ToList();
        }

        public async Task<DTOs.branch.BranchResponseDto> GetByIdAsync(int id)
        {
            var branch = await _repository.GetByIdAsync(id);

            if (branch == null)
                throw new Exception("Branch not found");

            return new DTOs.branch.BranchResponseDto
            {
                BranchId = branch.BranchId,
                BranchName = branch.BranchName,
                City = branch.City,
                State = branch.State
            };
        }

        public async Task UpdateAsync(int id, UpdateBranchDto dto)
        {
            var branch = await _repository.GetByIdAsync(id);

            if (branch == null)
                throw new Exception("Branch not found");

            branch.BranchName = dto.BranchName;
            branch.City = dto.City;
            branch.State = dto.State;

            _repository.Update(branch);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var branch = await _repository.GetByIdAsync(id);

            if (branch == null)
                throw new Exception("Branch not found");

            _repository.Remove(branch);
            await _unitOfWork.SaveChangesAsync();
        }

     
    }
    }
