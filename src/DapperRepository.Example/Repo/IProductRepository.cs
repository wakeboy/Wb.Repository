using DapperRepository.Example.Entities;

namespace DapperRepository.Example.Repo
{
    public interface IProductRepository : Wb.Repository.IRepository<Product, int>
    {
    }
}
