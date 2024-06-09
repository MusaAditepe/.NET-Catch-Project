using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Black Tshirt",
                    Price =100,
                    Stock=20,
                    CreatedDate = DateTime.Now,
                    
                },
                 new Product
                 {
                     Id = 2,
                     CategoryId = 1,
                     Name = "Green Tshirt",
                     Price = 200,
                     Stock = 30,
                     CreatedDate = DateTime.Now,

                 },
                  new Product
                  {
                      Id = 3,
                      CategoryId = 1,
                      Name = "Blue Tshirt",
                      Price = 600,
                      Stock = 60,
                      CreatedDate = DateTime.Now,

                  },
                   new Product
                   {
                       Id = 4,
                       CategoryId = 2,
                       Name = "Red Shoes",
                       Price = 600,
                       Stock = 60,
                       CreatedDate = DateTime.Now,

                   },
                   new Product
                   {
                       Id = 5,
                       CategoryId = 2,
                       Name = "Black Shoes",
                       Price = 900,
                       Stock = 60,
                       CreatedDate = DateTime.Now,

                   });
        }
    }
}
