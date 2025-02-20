using ArchMvc.Domain.Entities;
using ArchMvc.Domain.Interfaces;
using ArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ArchMvc.Infra.Data.Repositories;

public class CategoryRepository(ApplicationDbContext context) : ICategoryRepository
{
    public async Task<Category> CreateAsync(Category category)
    {
        context.Add(category);
        await context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> GetByIdAsync(int? id) => await context.Categories.FindAsync(id);

    public async Task<IEnumerable<Category>> GetCategoriesAsync() =>
        await context.Categories.ToListAsync();

    public async Task<Category> RemoveAsync(Category category)
    {
        context.Remove(category);
        await context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        context.Update(category);
        await context.SaveChangesAsync();
        return category;
    }
}
