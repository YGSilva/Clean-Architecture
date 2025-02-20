using ArchMvc.Domain.Entities;

namespace ArchMvc.Domain.Interfaces;

public interface IProductRepository
{
    Task<Product> GetProductCategoryAsync(int? id);
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetByIdAsync(int? id);
    Task<Product> CreateAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<Product> RemoveAsync(Product product);
}
