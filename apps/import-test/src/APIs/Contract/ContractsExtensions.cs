using ImportTest.APIs.Dtos;
using ImportTest.Infrastructure.Models;

namespace ImportTest.APIs.Extensions;

public static class ContractsExtensions
{
    public static Contract ToDto(this ContractDbModel model)
    {
        return new Contract
        {
            ClientId = model.ClientId,
            Created = model.Created,
            Createdby = model.Createdby,
            ExpireDate = model.ExpireDate,
            Id = model.Id,
            Modified = model.Modified,
            Modifiedby = model.Modifiedby,
            StartDate = model.StartDate,
            SubscriptionTypeField = model.SubscriptionTypeFieldId,
        };
    }

    public static ContractDbModel ToModel(
        this ContractUpdateInput updateDto,
        ContractWhereUniqueInput uniqueId
    )
    {
        var contract = new ContractDbModel
        {
            Id = uniqueId.Id,
            ExpireDate = updateDto.ExpireDate,
            Modified = updateDto.Modified,
            Modifiedby = updateDto.Modifiedby
        };

        if (updateDto.ClientId != null)
        {
            contract.ClientId = updateDto.ClientId;
        }
        if (updateDto.Created != null)
        {
            contract.Created = updateDto.Created.Value;
        }
        if (updateDto.Createdby != null)
        {
            contract.Createdby = updateDto.Createdby;
        }
        if (updateDto.StartDate != null)
        {
            contract.StartDate = updateDto.StartDate.Value;
        }
        if (updateDto.SubscriptionTypeField != null)
        {
            contract.SubscriptionTypeFieldId = updateDto.SubscriptionTypeField.Value;
        }

        return contract;
    }
}
