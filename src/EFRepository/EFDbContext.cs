using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

namespace Wb.Repository.EFRepository
{
    public class EFDbContext<TEntity, TId> : DbContext where TEntity : EFEntity<TId>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\sqlexpress;Database=NHibernateDemo;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var instance = Activator.CreateInstance(typeof(TEntity));
            var method = instance.GetType().GetMethod("Map");
            method.Invoke(instance, new [] { modelBuilder });
        }

        public DbSet<TEntity> Set { get; set; }
    }
}
