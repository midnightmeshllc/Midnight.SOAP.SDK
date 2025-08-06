
namespace Midnight.SOAP.SDK.CommonObjects;

public class CustomerAddress
{
    public string? CustomerAddressLine1 { get; set; } = string.Empty;
    public string? CustomerAddressLine2 { get; set; } = string.Empty;
    public string? CustomerAddressLine3 { get; set; } = string.Empty;
    public string? CustomerAddressCity { get; set; } = string.Empty;
    public string? CustomerAddressState { get; set; } = string.Empty;
    public string? CustomerAddressZip { get; set; } = string.Empty;
    public string? CustomerAddressCountry { get; set; } = "United States";
}
