using EFRepository.Example.Entities;

namespace EFRepository.Example.Repo
{
    public interface IProductRepository : Wb.Repository.IRepository<Product, int>
    {
    }
}
