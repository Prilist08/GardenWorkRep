using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using GardenERP.Application.Interface;
using GardenERP.Application.Services;
namespace GardenERP.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IItemCategoryService, ItemCategoryService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IPurchaseService, PurchaseService>();

            return services;
        }
    }
}
