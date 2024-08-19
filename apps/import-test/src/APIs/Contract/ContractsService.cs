using ImportTest.Infrastructure;

namespace ImportTest.APIs;

public class ContractsService : ContractsServiceBase
{
    public ContractsService(ImportTestDbContext context)
        : base(context) { }
}
