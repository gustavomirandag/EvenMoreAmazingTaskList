using EvenMoreAmazingTaskList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EvenMoreAmazingTaskList.Infrastructure
{
    public class EvenMoreAmazingTaskListDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        public EvenMoreAmazingTaskListDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EvenMoreAmazingTaskListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
