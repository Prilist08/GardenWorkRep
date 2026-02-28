using GardenERP.Application.DTOs.branch;
using GardenERP.Application.DTOs.Customer;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(ICustomerRepository repository,
                             IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> CreateAsync(DTOs.Customer.CreateUpdateCustomerDto dto)
        {
            var custmer = new Customer
            {
                // Will be set by the database
                FullName = dto.FullName,
                Mobile = dto.Mobile,
                Email = dto.Email,
                Address = dto.Address,

                CreatedAt = dto.CreatedAt ?? DateTime.UtcNow
            };

            await _repository.AddAsync(custmer);
            await _unitOfWork.SaveChangesAsync();

            return custmer.CustomerId;
        }

        //public async Task<List<DTOs.Customer.ResponseCustomerDto>> GetAllAsync()
        //{
        //    var branches = await _repository.GetAllAsync();

        //   // return branches.Select(b => new DTOs.Customer.ResponseCustomerDto);
        //    //{
        //    //    FullName = dto.FullName,
        //    //    Mobile = dto.Mobile,
        //    //    Email = dto.Email,
        //    //    Address = dto.Address,

        //    //    CreatedAt = dto.CreatedAt ?? DateTime.UtcNow
        //    //}).ToList();
        //}

        public async Task<DTOs.branch.BranchResponseDto> GetByIdAsync(int id)
        {
            var branch = await _repository.GetByIdAsync(id);

            if (branch == null)
                throw new Exception("Branch not found");

            return new DTOs.branch.BranchResponseDto
            {
                //BranchId = branch.BranchId,
                //BranchName = branch.BranchName,
                //City = branch.City,
                //State = branch.State
            };
        }

        public async Task UpdateAsync(int id, UpdateBranchDto dto)
        {
            var branch = await _repository.GetByIdAsync(id);

            if (branch == null)
                throw new Exception("Branch not found");

            //branch.BranchName = dto.BranchName;
            //branch.City = dto.City;
            //branch.State = dto.State;

            //_repository.Update(branch);
            //await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var branch = await _repository.GetByIdAsync(id);

            if (branch == null)
                throw new Exception("Branch not found");

            _repository.Remove(branch);
            await _unitOfWork.SaveChangesAsync();
        }

        Task<ResponseCustomerDto> ICustomerService.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, CreateUpdateCustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResponseCustomerDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
