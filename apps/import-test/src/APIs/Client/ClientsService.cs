using ImportTest.Infrastructure;

namespace ImportTest.APIs;

public class ClientsService : ClientsServiceBase
{
    public ClientsService(ImportTestDbContext context)
        : base(context) { }
}
