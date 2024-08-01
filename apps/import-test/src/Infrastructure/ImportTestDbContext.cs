using ImportTest.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace ImportTest.Infrastructure;

public class ImportTestDbContext : DbContext
{
    public ImportTestDbContext(DbContextOptions<ImportTestDbContext> options)
        : base(options) { }

    public DbSet<ClientDbModel> Clients { get; set; }

    public DbSet<ContractDbModel> Contracts { get; set; }

    public DbSet<SubscriptionTypeDbModel> SubscriptionTypes { get; set; }

    public DbSet<SystemTypeDbModel> SystemTypes { get; set; }

    public DbSet<UserDbModel> Users { get; set; }
}
