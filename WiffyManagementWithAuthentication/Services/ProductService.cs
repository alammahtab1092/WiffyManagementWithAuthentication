using WiffyManagementWithAuthentication.Context;
using WiffyManagementWithAuthentication.Data;
using Microsoft.EntityFrameworkCore;


namespace WiffyManagementWithAuthentication.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _applicationDbContext.Products.ToListAsync();
        }

        public async Task<bool> AddNewProduct(Product product)
        {
            await _applicationDbContext.Products.AddAsync(product);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Product> GetProductById(int productId)
        {
            Product product = await _applicationDbContext.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
            return product;
        }

        public async Task<bool> UpdateProductById(Product product)
        {

            _applicationDbContext.Products.Update(product);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProduct(Product product)
        {

            _applicationDbContext.Products.Remove(product);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
