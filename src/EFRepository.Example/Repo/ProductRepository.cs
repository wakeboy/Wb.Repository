using EFRepository.Example.Entities;
using System;
using Wb.Repository.EFRepository;

namespace EFRepository.Example.Repo
{
    public class ProductRepository : Repository<Product, int>, IProductRepository, IDisposable
    {
        public ProductRepository(EFDbContext<Product, int> context) : base(context)
        {
        }
    }
}
