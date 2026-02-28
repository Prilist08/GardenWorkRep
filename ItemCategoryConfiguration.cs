csharp GardenERP.Infrastructure\Configurations\ItemCategoryConfiguration.cs
using GardenERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GardenERP.Infrastructure.Configurations
{
    public class ItemCategoryConfiguration : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            // Define primary key because the property name is `CategoryId`
            // (EF Core convention expects `ItemCategoryId` or `Id` for this type).
            builder.HasKey(ic => ic.CategoryId);

            builder.Property(ic => ic.CategoryName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.HasOne(ic => ic.Branch)
                   .WithMany()
                   .HasForeignKey(ic => ic.BranchId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}