namespace Midnight.SOAP.SDK.CommonObjects;

/// <summary>
/// Represents a billing address in the Midnight SOAP API.
/// </summary>
public class BillingAddress
{
    /// <summary>Gets or sets the billing address name.</summary>
    public string? BillingAddressName { get; set; }
    /// <summary>Gets or sets the first line of the billing address.</summary>
    public string? BillingAddressLine1 { get; set; }
    /// <summary>Gets or sets the second line of the billing address.</summary>
    public string? BillingAddressLine2 { get; set; }
    /// <summary>Gets or sets the third line of the billing address.</summary>
    public string? BillingAddressLine3 { get; set; }
    /// <summary>Gets or sets the billing address city.</summary>
    public string? BillingAddressCity { get; set; }
    /// <summary>Gets or sets the billing address state.</summary>
    public string? BillingAddressState { get; set; }
    /// <summary>Gets or sets the billing address zip code.</summary>
    public string? BillingAddressZip { get; set; }
    /// <summary>Gets or sets the billing address country.</summary>
    public string? BillingAddressCountry { get; set; } = "United States";
}
