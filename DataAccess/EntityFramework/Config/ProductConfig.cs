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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product {Id=1,  CategoryId = 1, Name = "Çilek", Price = 45 ,ProductImage="cilek.jpg"},
                new Product { Id = 2, CategoryId = 1, Name = "Muz", Price = 49, ProductImage = "muz.jpg" },
                new Product { Id = 3, CategoryId = 1, Name = "Patates", Price = 15, ProductImage = "patates.jpg" },
                new Product { Id = 4, CategoryId = 1, Name = "Soğan", Price = 24, ProductImage = "sogan.jpg" },
                new Product { Id = 5, CategoryId = 2, Name = "Kıyma", Price = 224, ProductImage = "kıyma.jpg" },
                new Product { Id = 6, CategoryId = 2, Name = "Tavuk", Price = 136, ProductImage = "tavuk.jpg" },
                new Product { Id = 7, CategoryId = 3, Name = "Kola 2.5LT", Price = 46, ProductImage = "kola.jpg" },
                new Product { Id = 8, CategoryId = 3, Name = "Şalgam 1 LT", Price = 26, ProductImage = "salgam.jpg" },
                new Product { Id = 9, CategoryId = 4, Name = "Peynir", Price = 158, ProductImage = "peynir.jpg" },
                new Product { Id = 10, CategoryId = 4, Name = "Zeytin", Price = 67, ProductImage = "zeytin.jpg" },
                new Product { Id = 11, CategoryId = 4, Name = "Helva", Price = 92, ProductImage = "helva.jpg" },
                new Product { Id = 12, CategoryId = 5, Name = "Cif", Price = 32, ProductImage = "cif.jpg" },
                new Product { Id = 13, CategoryId = 5, Name = "Domestos", Price = 63, ProductImage = "domestos.jpg" },
                new Product { Id = 14, CategoryId = 6, Name = "Yarış Arabası", Price = 254, ProductImage = "yarisarabasi.jpg" },
                new Product { Id = 15, CategoryId = 6, Name = "Bebek Bezi 0-1 Yaş", Price = 314, ProductImage = "bebekbezi.jpg" },
                new Product { Id = 16, CategoryId = 7, Name = "Tuvalet Kağıdı", Price = 144, ProductImage = "tuvaletkagidi.jpg" },
                new Product { Id = 17, CategoryId = 7, Name = "Dedorant", Price = 72, ProductImage = "dedorant.jpg" },
                new Product { Id = 18, CategoryId = 8, Name = "Makarna", Price = 18, ProductImage = "makarna.jpg" },
                new Product { Id = 19, CategoryId = 8, Name = "Pirinç Baldo", Price = 38, ProductImage = "pirinc.jpg" },
                new Product { Id = 20, CategoryId = 8, Name = "Çorba", Price = 13, ProductImage = "corba.jpg" }
                ); 
        }
    }
}
