using Microsoft.EntityFrameworkCore;

namespace ImportTest.Infrastructure;

public class ImportTestDbContext : DbContext
{
    public ImportTestDbContext(DbContextOptions<ImportTestDbContext> options)
        : base(options) { }
}
