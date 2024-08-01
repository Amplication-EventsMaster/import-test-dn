using ImportTest.APIs.Common;
using ImportTest.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImportTest.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class SubscriptionTypeFindManyArgs
    : FindManyInput<SubscriptionType, SubscriptionTypeWhereInput> { }
