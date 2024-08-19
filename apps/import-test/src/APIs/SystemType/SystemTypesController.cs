using Microsoft.AspNetCore.Mvc;

namespace ImportTest.APIs;

[ApiController()]
public class SystemTypesController : SystemTypesControllerBase
{
    public SystemTypesController(ISystemTypesService service)
        : base(service) { }
}
