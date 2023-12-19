using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDbContext _context;
        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            this._context = shopOnlineDbContext;   
        }
        async Task<IEnumerable<ProductCategory>> IProductRepository.GetCategories()
        {
            var categories = await _context.ProductCategories.ToListAsync();

            return categories;
        }

        Task<ProductCategory> IProductRepository.GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        Task<Product> IProductRepository.GetItem(int id)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Product>> IProductRepository.GetItems()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }
    }
}
