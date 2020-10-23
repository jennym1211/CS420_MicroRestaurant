using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MicroRestaurant.Models;
using System.Security;
using System.ComponentModel;

namespace MicroRestaurant.Data
{
    public class MicroRestaurantContext : DbContext
    {
        public MicroRestaurantContext(DbContextOptions<MicroRestaurantContext> options)
            : base(options)
        {
        }

        public MicroRestaurantContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>()
                .HasData(
                new MenuItem { Id = 1, Name = "Water", Description = "A 16 oz glass of water.", Price = 0.00M, Type = "Drink", },
                new MenuItem { Id = 2, Name = "Soda", Description = "A 16 oz glass of soda.", Price = 2.00M, Type = "Drink", },
                new MenuItem { Id = 3, Name = "Beer", Description = "A glass of beer, served in a stein.", Price = 8.00M, Type = "Alcholic Drink", },
                new MenuItem { Id = 4, Name = "Cheese Omelette", Description = "A simple omellete coated with American Cheese, and a light sprinkle of salt and pepper.", Price = 4.00M, Type = "Food", },
                new MenuItem { Id = 5, Name = "Medium Steak", Description = "A 8oz steak cooked to your preference.", Price = 8.00M, Type = "Food", },
                new MenuItem { Id = 6, Name = "BLT Sandwich", Description = "A toasted BLT sandwich", Price = 5.00M, Type = "Food", }

                );
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Table> Table { get; set; }
    }
}