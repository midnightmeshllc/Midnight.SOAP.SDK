
namespace Midnight.SOAP.SDK.CommonObjects;

public class ShippingAddress
{
    public string? ShippingAddressName { get; set; } = string.Empty;
    public string? ShippingAddressLine1 { get; set; } = string.Empty;
    public string? ShippingAddressLine2 { get; set; } = string.Empty;
    public string? ShippingAddressLine3 { get; set; } = string.Empty;
    public string? ShippingAddressCity { get; set; } = string.Empty;
    public string? ShippingAddressState { get; set; } = string.Empty;
    public string? ShippingAddressZip { get; set; } = string.Empty;
    public string? ShippingAddressCountry { get; set; } = "United States";
    public string? ShippingMethod { get; set; } = string.Empty;
}
