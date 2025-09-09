namespace Midnight.SOAP.SDK.CommonObjects;

/// <summary>
/// Represents a customer address in the Midnight SOAP API.
/// </summary>
public class CustomerAddress
{
    /// <summary>Gets or sets the first line of the customer address.</summary>
    public string? CustomerAddressLine1 { get; set; } = string.Empty;
    /// <summary>Gets or sets the second line of the customer address.</summary>
    public string? CustomerAddressLine2 { get; set; } = string.Empty;
    /// <summary>Gets or sets the third line of the customer address.</summary>
    public string? CustomerAddressLine3 { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer address city.</summary>
    public string? CustomerAddressCity { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer address state.</summary>
    public string? CustomerAddressState { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer address zip code.</summary>
    public string? CustomerAddressZip { get; set; } = string.Empty;
    /// <summary>Gets or sets the customer address country.</summary>
    public string? CustomerAddressCountry { get; set; } = "United States";
}
