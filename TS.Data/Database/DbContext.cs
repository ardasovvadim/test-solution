using Microsoft.EntityFrameworkCore;
using TS.Data.Entities;

namespace TS.Data.Database
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseEntity>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}