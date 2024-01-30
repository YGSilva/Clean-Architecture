using ArchMvc.Domain.Entities;

namespace ArchMvc.Domain.Interfaces;
public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductCategorYAsync();
    Task<Product> GetByIdAsync(int? id);
    Task<Product> CreateAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<Product> RemoveAsync(Product product);
}