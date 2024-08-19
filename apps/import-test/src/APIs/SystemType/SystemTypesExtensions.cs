using ImportTest.APIs.Dtos;
using ImportTest.Infrastructure.Models;

namespace ImportTest.APIs.Extensions;

public static class SystemTypesExtensions
{
    public static SystemType ToDto(this SystemTypeDbModel model)
    {
        return new SystemType
        {
            Client = model.Client?.Select(x => x.Id).ToList(),
            Description = model.Description,
            Id = model.Id,
        };
    }

    public static SystemTypeDbModel ToModel(
        this SystemTypeUpdateInput updateDto,
        SystemTypeWhereUniqueInput uniqueId
    )
    {
        var systemType = new SystemTypeDbModel { Id = uniqueId.Id };

        if (updateDto.Description != null)
        {
            systemType.Description = updateDto.Description;
        }

        return systemType;
    }
}
