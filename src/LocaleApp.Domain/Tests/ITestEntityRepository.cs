using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocaleApp.Domain.Abstractions.Repositories;

namespace LocaleApp.Domain.Tests;
public interface ITestEntityRepository:IGenericRepository<TestEntity>
{
}
