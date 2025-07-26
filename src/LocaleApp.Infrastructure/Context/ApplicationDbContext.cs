using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocaleApp.Domain.Tests;
using Microsoft.EntityFrameworkCore;

namespace LocaleApp.Infrastructure.Context;
public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions opt):base(opt)
    {
        
    }
    public DbSet<TestEntity> TestEntities { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Apply configurations here if needed
        // Example: modelBuilder.ApplyConfiguration(new MyEntityConfiguration());
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly); // This will apply all configurations in the assembly
    }
    
    public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        // You can add custom logic here before saving changes
        // For example, setting timestamps or auditing
        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }
}
