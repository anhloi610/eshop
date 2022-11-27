using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() {
                   Key = "HomeTitle",
                   Value = "THIS IS HOME PAGE OF SOLUTION" },
               new AppConfig() {
                   Key = "HomeDescription",
                   Value = "THIS IS DESCRIPTION  OF SOLUTION" },
               new AppConfig() {
                   Key = "HomeKeyWord",
                   Value = "THIS IS KEYWORD  OF SOLUTION" }
            );
            modelBuilder.Entity<Language>().HasData(
               new Language() {
                   Id = "vi-VN",
                   Name = "Tiếng việt",
                   IsDefault = true },
               new Language() {
                   Id = "en-US",
                   Name = "English",
                   IsDefault = false }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product() {
                    ID = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    Viewcount = 0
                },
                new Product()
                {
                    ID = 2,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    Viewcount = 0
                }
                );
                modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id =1,
                    ProductId = 1,
                    Name = "Áo Nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "",
                    SeoDescription = "Áo thời trang Nam",
                    SeoTitle = "Sản phẩm áo thời trang nam",
                    Details = "Mô tả sản phẩm",
                    Description = "..."
                },
                new ProductTranslation()
                {
                    Id =2,
                    ProductId = 1,
                    Name = "Men Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "",
                    SeoDescription = "The Shirt for the man",
                    SeoTitle = "The shirt for the man",
                    Details = "Description for the products",
                    Description = "..."
                },
                new ProductTranslation()
                {
                    Id =3,
                    ProductId = 2,
                    Name = "Áo Nữ sơ mi CPBAOLAM",
                    LanguageId = "vi-VN",
                    SeoAlias = "Áo Nữ sơ mi CPBAOLAM",
                    SeoDescription = "Áo Nữ sơ mi CPBAOLAM",
                    SeoTitle = "Áo Nữ sơ mi CPBAOLAM",
                    Details= "Aó sơ mi mỏng trắng",
                    Description = "Aó sơ mi số 1 việt nam"
                },
                new ProductTranslation()
                {
                    Id = 4,
                    ProductId = 2,
                    Name = "Women of Shirt ",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The Shirt for the women",
                    SeoTitle = "women-shirt",
                    Details = "The white shirt "
                    
                }
                );
                 modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                { 
                    ProductId = 1,
                    CategoryId = 1
                },
                new ProductInCategory()
                {
                    ProductId = 2,
                    CategoryId =2
                }
                );
                modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() {
                    Id =1,
                    CategoryId = 1,
                    Name = "Áo Nam sơ mi CPBAOLAM",
                    LanguageId = "vi-VN",
                    SeoAlias = "Áo Nam sơ mi CPBAOLAM",
                    SeoDescription = "Áo Nam sơ mi CPBAOLAM",
                    SeoTitle = "Áo Nam sơ mi CPBAOLAM"
                },
                new CategoryTranslation()
                {
                    Id =2,
                    CategoryId = 1,
                    Name = "Men Shirt ",
                    LanguageId = "en-US",
                    SeoAlias = "",
                    SeoDescription = "The Shirt for the man",
                    SeoTitle = ""
                },                   
                new CategoryTranslation() {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Áo Nữ sơ mi CPBAOLAM",
                    LanguageId = "vi-VN",
                    SeoAlias = "Áo Nữ sơ mi CPBAOLAM",
                    SeoDescription = "Áo Nữ sơ mi CPBAOLAM",
                    SeoTitle = "Áo Nữ sơ mi CPBAOLAM"
                },
                new CategoryTranslation() {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Women of Shirt ",
                    LanguageId = "en-US",
                    SeoAlias = "women-shirt",
                    SeoDescription = "The Shirt for the women",
                    SeoTitle = "women-shirt"
                }
            );    
                modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active,
                 }
                 
            );
         }
    }
}
