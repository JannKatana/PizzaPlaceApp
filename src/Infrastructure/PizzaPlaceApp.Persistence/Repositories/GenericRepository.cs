using PizzaPlaceApp.Application.Contracts.Persistence;
using PizzaPlaceApp.Domain.Common;
using PizzaPlaceApp.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace PizzaPlaceApp.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly PizzaPlaceDatabaseContext Context;

    public GenericRepository(PizzaPlaceDatabaseContext context)
    {
        Context = context;
    }


    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await Context.Set<T>().AsNoTracking()
            .ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await Context.Set<T>().AsNoTracking()
            .FirstOrDefaultAsync(q => q.Id == id);
    }

    public async Task CreateAsync(T entity)
    {
        await Context.AddAsync(entity);
        await Context.SaveChangesAsync();
    }

    public async Task CreateRangeAsync(IEnumerable<T> entities)
    {
        await Context.AddRangeAsync(entities);
        await Context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        Context.Entry(entity).State = EntityState.Modified;
        await Context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        Context.Remove(entity);
        await Context.SaveChangesAsync();
    }
}