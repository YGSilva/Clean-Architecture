using ArchMvc.Domain.Entities;

namespace ArchMvc.Domain.Interfaces;
public interface ICategoryRepository
{
    Task<IEnumerable<Product>> GetCategoriesAsync();
    Task<Product> GetByIdAsync(int? id);
    Task<Product> CreateAsync(Product category);
    Task<Product> UpdateAsync(Product category);
    Task<Product> RemoveAsync(Product category);
}