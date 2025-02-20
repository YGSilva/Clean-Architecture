using ArchMvc.Domain.Entities;
using ArchMvc.Domain.Interfaces;
using ArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ArchMvc.Infra.Data.Repositories;

public class ProductRepository(ApplicationDbContext context) : IProductRepository
{
    public async Task<Product> CreateAsync(Product product)
    {
        context.Add(product);
        await context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> GetByIdAsync(int? id) => await context.Products.FindAsync(id);

    public async Task<Product> GetProductCategoryAsync(int? id) =>
        await context.Products.Include(c => c.Category).SingleOrDefaultAsync(p => p.Id == id);

    public async Task<IEnumerable<Product>> GetProductsAsync() =>
        await context.Products.ToListAsync();

    public async Task<Product> RemoveAsync(Product product)
    {
        context.Remove(product);
        await context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> UpdateAsync(Product product)
    {
        context.Update(product);
        await context.SaveChangesAsync();
        return product;
    }
}
