using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);//This .AddAsync in saying change the entity state of this entity to add it
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            context.Set<T>().Remove(entity);//so by using Set<T> we are making something generic because we don't know from which table we need tp fetch data or delete data
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            context.Update(entity);
            return context.SaveChangesAsync();
        }
    }
}
