using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LocaleApp.Domain.Abstractions;
using LocaleApp.Domain.Abstractions.Repositories;
using LocaleApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace LocaleApp.Infrastructure.Repositories;
public  class GenericRepository<T> : IGenericRepository<T> where T : Entity
{
    private readonly DbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(DbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _dbSet=dbContext.Set<T>();
    }
    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<List<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<T>> GetAllQueryable()
    {
        throw new NotImplementedException();
    }

    public Task<T?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
