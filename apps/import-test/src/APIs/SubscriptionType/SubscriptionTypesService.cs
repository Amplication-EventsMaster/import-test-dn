using ImportTest.Infrastructure;

namespace ImportTest.APIs;

public class SubscriptionTypesService : SubscriptionTypesServiceBase
{
    public SubscriptionTypesService(ImportTestDbContext context)
        : base(context) { }
}
