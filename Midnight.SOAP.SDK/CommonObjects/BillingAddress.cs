
namespace Midnight.SOAP.SDK.CommonObjects;

public class BillingAddress
{
    public string? BillingAddressName { get; set; }
    public string? BillingAddressLine1 { get; set; }
    public string? BillingAddressLine2 { get; set; }
    public string? BillingAddressLine3 { get; set; }
    public string? BillingAddressCity { get; set; }
    public string? BillingAddressState { get; set; }
    public string? BillingAddressZip { get; set; }
    public string? BillingAddressCountry { get; set; } = "United States";
}
