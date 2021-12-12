using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page eShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword eShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Description eShop" });
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });
            modelBuilder.Entity<Category>().HasData(
               new Category() {
                   Id = 1,
                   IsShowOnHome = true,
                   ParentId = null, SortOrder = 1,
                   Status = Status.Active
               },
               new Category()
               {
                   Id=2,
                   IsShowOnHome = true,
                   ParentId = null,
                   SortOrder = 2,
                   Status = Status.Active
               });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Đồng hồ Rolex",
                    LanguageId = "vi-VN",
                    SeoAlias = "dong-ho-rolex",
                    SeoTitle = "Đồng hồ thời trang cao cấp",
                    SeoDescription = "Đồng hồ thời trang cao cấp"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Rolex Watch",
                    LanguageId = "en-US",
                    SeoAlias = "rolex-watch",
                    SeoTitle = "Rolex watch model",
                    SeoDescription = "Rolex watch model"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Đồng hồ Casio",
                    LanguageId = "vi-VN",
                    SeoAlias = "dong-ho-casio",
                    SeoTitle = "Đồng hồ thời trang cao cấp",
                    SeoDescription = "Đồng hồ thời trang cao cấp"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Casio Watch",
                    LanguageId = "en-US",
                    SeoAlias = "casio-watch",
                    SeoTitle = "Casio watch model",
                    SeoDescription = "Casio watch model"
                }
                ); 
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 2000000,
                    Price = 2500000,
                    Stock = 0,
                    ViewCount = 0,
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Đồng hồ Rolex - 007",
                     LanguageId = "vi-VN",
                     SeoAlias = "dong-ho-rolex-007",
                     SeoTitle = "Đồng hồ thời trang cao cấp Thụy Điển",
                     SeoDescription = "Đồng hồ thời trang cao cấp Thụy Điển",
                     Details = "đồng hồ cao cấp Thụy Điển",
                     Description = ""
                 },
                 new ProductTranslation()
                 {
                     Id = 2,
                     ProductId = 1,
                     Name = "Rolex Watch - 007",
                     LanguageId = "en-US",
                     SeoAlias = "rolex-watch-007",
                     SeoTitle = "Rolex watch model Swedish",
                     SeoDescription = "Rolex watch model Swedish",
                     Details = "England watch",
                     Description = ""
                 }
           );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 });
            var roleID = new Guid("DFEBD283-B105-410C-BF66-6C162F85C927");
            var adminID = new Guid("AACD418D-46F4-4175-B6B7-9F2D42993FA6");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleID,
                Name = "Admin",
                NormalizedName = "admin",
                Description = "Admin Role"
            });
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Huy",
                LastName = "Nguyen",
                Dob = new DateTime(2000,08,28)
            });
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleID,
                UserId = adminID
            });
        }
    }
}
