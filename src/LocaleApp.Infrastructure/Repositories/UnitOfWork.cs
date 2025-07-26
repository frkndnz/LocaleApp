using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocaleApp.Domain.Abstractions.Repositories;
using LocaleApp.Domain.Tests;
using LocaleApp.Infrastructure.Context;

namespace LocaleApp.Infrastructure.Repositories;
public class UnitOfWork : IUnitofWork
{
    private readonly ApplicationDbContext _dbContext;
    public ITestEntityRepository Tests { get; set; }
    public UnitOfWork(ApplicationDbContext applicationDbContext)
    {
        _dbContext = applicationDbContext;
        Tests = new TestEntityRepository(_dbContext);
    }
    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
       return await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
