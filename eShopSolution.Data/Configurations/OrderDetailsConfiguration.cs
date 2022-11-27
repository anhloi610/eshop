using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using eShopSolution.Data.Entities;
namespace eShopSolution.Data.Configurations
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderInOrderdetails");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
