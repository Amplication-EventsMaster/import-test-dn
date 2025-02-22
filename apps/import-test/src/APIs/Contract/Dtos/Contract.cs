namespace ImportTest.APIs.Dtos;

public class Contract
{
    public string ClientId { get; set; }

    public DateTime Created { get; set; }

    public string Createdby { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string Id { get; set; }

    public DateTime? Modified { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime StartDate { get; set; }

    public int SubscriptionTypeField { get; set; }
}
