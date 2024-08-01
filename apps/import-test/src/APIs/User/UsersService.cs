using ImportTest.Infrastructure;

namespace ImportTest.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(ImportTestDbContext context)
        : base(context) { }
}
