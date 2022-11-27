using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Entities;
namespace eShopSolution.Data.Configurations
{
    public class ProductInCatergoryCf : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });
            builder.ToTable("ProductInCatergory");
            builder.HasOne(t => t.Product).WithMany(k => k.ProductInCategories).HasForeignKey(k => k.ProductId);
            builder.HasOne(t => t.Category).WithMany(k => k.ProductInCategories).HasForeignKey(k => k.CategoryId);
        }
    }
}
