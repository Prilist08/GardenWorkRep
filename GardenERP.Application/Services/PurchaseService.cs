using GardenERP.Application.DTOs;
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
    public class PurchaseService : IPurchaseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PurchaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> CreateAsync(CreatePurchaseDto dto)
        {
            if (dto.Items == null || !dto.Items.Any())
                throw new Exception("Purchase must contain items.");

            var purchase = new Purchase
            {
                BranchId = dto.BranchId,
                SupplierId = dto.SupplierId,
                InvoiceNo = dto.InvoiceNo,
                PurchaseDate = dto.PurchaseDate
            };

            await _unitOfWork.Purchases.AddAsync(purchase);

            foreach (var item in dto.Items)
            {
                var detail = new PurchaseDetail
                {
                    PurchaseId = purchase.PurchaseId,
                    ItemId = item.ItemId,
                    Quantity = item.Quantity,
                    Rate = item.Rate,
                    Amount = item.Quantity * item.Rate
                };

                await _unitOfWork.PurchaseDetails.AddAsync(detail);

                var ledger = new StockLedger
                {
                    BranchId = dto.BranchId,
                    ItemId = item.ItemId,
                    RefType = "Purchase",
                    QuantityIn = item.Quantity,
                    QuantityOut = 0,
                    TransactionDate = DateTime.UtcNow
                };

                await _unitOfWork.StockLedgers.AddAsync(ledger);
            }

            await _unitOfWork.SaveChangesAsync();

            return purchase.PurchaseId;
        }
    }
}
