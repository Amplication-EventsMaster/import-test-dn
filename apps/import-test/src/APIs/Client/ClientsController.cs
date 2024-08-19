using Microsoft.AspNetCore.Mvc;

namespace ImportTest.APIs;

[ApiController()]
public class ClientsController : ClientsControllerBase
{
    public ClientsController(IClientsService service)
        : base(service) { }
}
