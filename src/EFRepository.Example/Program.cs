using EFRepository.Example.Entities;
using EFRepository.Example.Repo;
using System;
using System.Linq;

namespace Wb.Repository.EFRepository.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EFDbContext<Product, int> context = new EFDbContext<Product, int>();  
            IProductRepository repo = new ProductRepository(context);

            AddProduct(repo);

            var products = repo.GetAll();

            foreach(var p in products)
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadKey();
        }

        public static void AddProduct(IProductRepository repo)
        {
            var product = new Product()
            {
                Id = repo.GetAll().Max(p => p.Id) + 1,
                Name = "Product Name",
                Description = "Product Description"
            };

            repo.Add(product);
        }
    }
}
