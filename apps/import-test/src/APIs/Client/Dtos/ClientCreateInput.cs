namespace ImportTest.APIs.Dtos;

public class ClientCreateInput
{
    public string? CompanyName { get; set; }

    public DateTime Created { get; set; }

    public string Createdby { get; set; }

    public string? DefaultCultureCode { get; set; }

    public string? Id { get; set; }

    public bool? IsSokClient { get; set; }

    public DateTime? Modified { get; set; }

    public string? Modifiedby { get; set; }

    public string? NumberField { get; set; }

    public SystemType? SystemTypeField { get; set; }
}
