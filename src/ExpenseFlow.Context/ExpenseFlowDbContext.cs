using ExpenseFlow.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseFlow.Context
{
    public class ExpenseFlowDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connectionString = @"Server=.\;Database=ExpenseFlow;Trusted_Connection=True;";
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExpenseFlow;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("ExpenseFlow.DataAccess"));
            }
        }

        public ExpenseFlowDbContext(DbContextOptions<ExpenseFlowDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: Add default data

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                UserName = "Mads Mikkelsen",
                PasswordHash = "123",
                PasswordSalt = "123",
                Email = "MadsMikkelsen@gmail.com"
            });
        }
    }
}
