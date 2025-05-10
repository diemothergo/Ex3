using Microsoft.EntityFrameworkCore;
using Ex3.Models;

namespace Ex3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<Item>().HasData(new Item { ItemID = i, ItemName = $"Item{i}", Size = $"Size{i}" });
                modelBuilder.Entity<Agent>().HasData(new Agent { AgentID = i, AgentName = $"Agent{i}", Address = $"Address{i}" });
                modelBuilder.Entity<User>().HasData(new User { UserID = i, UserName = $"User{i}", Email = $"user{i}@example.com", Password = "password", Lock = false });
            }

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, OrderDate = new DateTime(2025, 5, 8), AgentID = 1 },
                new Order { OrderID = 2, OrderDate = new DateTime(2025, 5, 7), AgentID = 2 },
                new Order { OrderID = 3, OrderDate = new DateTime(2025, 5, 6), AgentID = 3 },
                new Order { OrderID = 4, OrderDate = new DateTime(2025, 5, 5), AgentID = 4 },
                new Order { OrderID = 5, OrderDate = new DateTime(2025, 5, 4), AgentID = 5 },
                new Order { OrderID = 6, OrderDate = new DateTime(2025, 5, 3), AgentID = 6 },
                new Order { OrderID = 7, OrderDate = new DateTime(2025, 5, 2), AgentID = 7 },
                new Order { OrderID = 8, OrderDate = new DateTime(2025, 5, 1), AgentID = 8 },
                new Order { OrderID = 9, OrderDate = new DateTime(2025, 4, 30), AgentID = 9 },
                new Order { OrderID = 10, OrderDate = new DateTime(2025, 4, 29), AgentID = 10 },
                new Order { OrderID = 11, OrderDate = new DateTime(2025, 4, 28), AgentID = 11 },
                new Order { OrderID = 12, OrderDate = new DateTime(2025, 4, 27), AgentID = 12 },
                new Order { OrderID = 13, OrderDate = new DateTime(2025, 4, 26), AgentID = 13 },
                new Order { OrderID = 14, OrderDate = new DateTime(2025, 4, 25), AgentID = 14 },
                new Order { OrderID = 15, OrderDate = new DateTime(2025, 4, 24), AgentID = 15 }
            );

            for (int i = 1; i <= 15; i++)
            {
                modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail { ID = i, OrderID = i, ItemID = i, Quantity = i, UnitAmount = 10.0m * i });
            }
        }
    }
}