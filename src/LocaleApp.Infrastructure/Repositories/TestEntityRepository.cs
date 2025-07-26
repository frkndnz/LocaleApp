using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocaleApp.Domain.Tests;
using Microsoft.EntityFrameworkCore;

namespace LocaleApp.Infrastructure.Repositories;
internal sealed class TestEntityRepository : GenericRepository<TestEntity>,ITestEntityRepository
{
    public TestEntityRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
