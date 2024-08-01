using Microsoft.AspNetCore.Mvc;

namespace ImportTest.APIs;

[ApiController()]
public class ContractsController : ContractsControllerBase
{
    public ContractsController(IContractsService service)
        : base(service) { }
}
