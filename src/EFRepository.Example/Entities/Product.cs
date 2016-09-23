using Microsoft.EntityFrameworkCore;
using Wb.Repository.EFRepository;

namespace EFRepository.Example.Entities
{
    public class Product : EFEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public override void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity => {
                entity.ToTable("Product");
                entity.Property(e => e.Id).IsRequired();
                entity.Property(e => e.Name);
                entity.Property(e => e.Description);
            });
        }
    }
}
