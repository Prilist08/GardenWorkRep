using GardenERP.Domain.Interfaces;
using GardenERP.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using GardenERP.Application.Interface;
using GardenERP.Application.Services;

namespace GardenERP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            // Unit Of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Repositories
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<IBranchService, BranchService>();

            // Fix: Register IItemRepository with the correct implementation
            //services.AddScoped<GardenERP.Domain.Interfaces.IItemRepository, GardenERP.Infrastructure.Repositories.ItemRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();

            // Fix: Register IItemCategoryRepository with the correct implementation
            services.AddScoped<IItemCategoryRepository, ItemCategoryRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IBranchRepository, BranchRepository>();

            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            services.AddScoped<IPurchaseDetailRepository, PurchaseDetailRepository>();
            services.AddScoped<IStockLedgerRepository, StockLedgerRepository>();

            return services;
        }
    }
}
