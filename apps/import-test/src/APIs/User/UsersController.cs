using Microsoft.AspNetCore.Mvc;

namespace ImportTest.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}
