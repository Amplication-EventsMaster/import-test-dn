using Microsoft.AspNetCore.Mvc;

namespace ImportTest.APIs;

[ApiController()]
public class SubscriptionTypesController : SubscriptionTypesControllerBase
{
    public SubscriptionTypesController(ISubscriptionTypesService service)
        : base(service) { }
}
