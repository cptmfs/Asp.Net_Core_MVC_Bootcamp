using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category {  Id=1, CategoryName="Fruits & Vegetables"},
                new Category {  Id=2, CategoryName="Meat"},
                new Category {  Id=3, CategoryName="Drink"},
                new Category {  Id=4, CategoryName= "Breakfast" },
                new Category {  Id=5, CategoryName= "Cleaning Products" },
                new Category {  Id=6, CategoryName= "Baby & Toy" },
                new Category {  Id=7, CategoryName= "Paper & Cosmetics" },
                new Category {  Id=8, CategoryName= "Food Products" }
                );
        }
    }
}
