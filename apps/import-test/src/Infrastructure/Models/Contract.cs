using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImportTest.Infrastructure.Models;

[Table("Contracts")]
public class ContractDbModel
{
    [Required()]
    [StringLength(256)]
    public string ClientId { get; set; }

    [Required()]
    public DateTime Created { get; set; }

    [Required()]
    [StringLength(256)]
    public string Createdby { get; set; }

    public DateTime? ExpireDate { get; set; }

    [Key()]
    [Required()]
    public string Id { get; set; }

    public DateTime? Modified { get; set; }

    [StringLength(256)]
    public string? Modifiedby { get; set; }

    [Required()]
    public DateTime StartDate { get; set; }

    public int SubscriptionTypeFieldId { get; set; }

    [ForeignKey(nameof(SubscriptionTypeFieldId))]
    public SubscriptionTypeDbModel SubscriptionTypeField { get; set; } = null;
}
