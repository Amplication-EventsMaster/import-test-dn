using ImportTest.Infrastructure;

namespace ImportTest.APIs;

public class SystemTypesService : SystemTypesServiceBase
{
    public SystemTypesService(ImportTestDbContext context)
        : base(context) { }
}
