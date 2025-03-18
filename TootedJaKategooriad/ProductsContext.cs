using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Cheese"},
                new Category { CategoryID = 2, CategoryName = "Meat" },
                new Category { CategoryID = 3, CategoryName = "Fish" },
                new Category { CategoryID = 4, CategoryName = "Bread" },
                new Category { CategoryID = 5, CategoryName = "Vegetables" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Cheddar"},
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Brie"},
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Stilton"},
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Cheshire"},
                new Product { ProductID = 5, CategoryID = 1, ProductName = "Swiss"},
                new Product { ProductID = 6, CategoryID = 1, ProductName = "Gruyere"},
                new Product { ProductID = 7, CategoryID = 1, ProductName = "Colby"},
                new Product { ProductID = 8, CategoryID = 1, ProductName = "Mozzarella"},
                new Product { ProductID = 9, CategoryID = 1, ProductName = "Parmigiano Reggiano"},
                new Product { ProductID = 10, CategoryID = 1, ProductName = "Hiirte Juust" },
                new Product { ProductID = 11, CategoryID = 2, ProductName = "Ham" },
                new Product { ProductID = 12, CategoryID = 2, ProductName = "Beef" },
                new Product { ProductID = 13, CategoryID = 2, ProductName = "Chicken" },
                new Product { ProductID = 14, CategoryID = 2, ProductName = "Turkey" },
                new Product { ProductID = 15, CategoryID = 2, ProductName = "Prosciutto" },
                new Product { ProductID = 16, CategoryID = 2, ProductName = "Bacon" },
                new Product { ProductID = 17, CategoryID = 2, ProductName = "Mutton" },
                new Product { ProductID = 18, CategoryID = 2, ProductName = "Pastrami" },
                new Product { ProductID = 19, CategoryID = 2, ProductName = "Hazlet" },
                new Product { ProductID = 20, CategoryID = 2, ProductName = "Salami" },
                new Product { ProductID = 21, CategoryID = 3, ProductName = "Salmon" },
                new Product { ProductID = 22, CategoryID = 3, ProductName = "Tuna" },
                new Product { ProductID = 23, CategoryID = 3, ProductName = "Mackerel" },
                new Product { ProductID = 24, CategoryID = 3, ProductName = "Sprats" },
                new Product { ProductID = 25, CategoryID = 4, ProductName = "Rye" },
                new Product { ProductID = 26, CategoryID = 4, ProductName = "Wheat" },
                new Product { ProductID = 27, CategoryID = 4, ProductName = "Brioche" },
                new Product { ProductID = 28, CategoryID = 4, ProductName = "Naan" },
                new Product { ProductID = 29, CategoryID = 4, ProductName = "Focaccia" },
                new Product { ProductID = 30, CategoryID = 4, ProductName = "Sourdough" },
                new Product { ProductID = 31, CategoryID = 4, ProductName = "Corn" },
                new Product { ProductID = 32, CategoryID = 4, ProductName = "Soda" },
                new Product { ProductID = 33, CategoryID = 4, ProductName = "Bread roll" },
                new Product { ProductID = 34, CategoryID = 4, ProductName = "Wonderbread" },
                new Product { ProductID = 35, CategoryID = 5, ProductName = "Potato" },
                new Product { ProductID = 36, CategoryID = 5, ProductName = "Carrot" },
                new Product { ProductID = 37, CategoryID = 5, ProductName = "Swede" },
                new Product { ProductID = 38, CategoryID = 5, ProductName = "Turnip" },
                new Product { ProductID = 39, CategoryID = 5, ProductName = "Leek" },
                new Product { ProductID = 40, CategoryID = 5, ProductName = "Tomato" },
                new Product { ProductID = 41, CategoryID = 5, ProductName = "Paprika" });
        }
    }
}
