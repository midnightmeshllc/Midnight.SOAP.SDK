namespace Midnight.SOAP.SDK.CommonObjects;

/// <summary>
/// Represents a shipping address in the Midnight SOAP API.
/// </summary>
public class ShippingAddress
{
    /// <summary>Gets or sets the shipping address name.</summary>
    public string? ShippingAddressName { get; set; } = string.Empty;
    /// <summary>Gets or sets the first line of the shipping address.</summary>
    public string? ShippingAddressLine1 { get; set; } = string.Empty;
    /// <summary>Gets or sets the second line of the shipping address.</summary>
    public string? ShippingAddressLine2 { get; set; } = string.Empty;
    /// <summary>Gets or sets the third line of the shipping address.</summary>
    public string? ShippingAddressLine3 { get; set; } = string.Empty;
    /// <summary>Gets or sets the shipping address city.</summary>
    public string? ShippingAddressCity { get; set; } = string.Empty;
    /// <summary>Gets or sets the shipping address state.</summary>
    public string? ShippingAddressState { get; set; } = string.Empty;
    /// <summary>Gets or sets the shipping address zip code.</summary>
    public string? ShippingAddressZip { get; set; } = string.Empty;
    /// <summary>Gets or sets the shipping address country.</summary>
    public string? ShippingAddressCountry { get; set; } = "United States";
    /// <summary>Gets or sets the shipping method.</summary>
    public string? ShippingMethod { get; set; } = string.Empty;
}
