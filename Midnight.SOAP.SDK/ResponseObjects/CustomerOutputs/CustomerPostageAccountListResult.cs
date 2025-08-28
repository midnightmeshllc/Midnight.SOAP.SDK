using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

/// <summary>
/// Represents the result of a customer postage account list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerPostageAccountListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of customer postage accounts returned by the request.
    /// </summary>
    [XmlArray("CustomerPostageAccounts")]
    [XmlArrayItem("CustomerPostageAccount")]
    public List<CustomerPostageAccount>? CustomerPostageAccounts { get; set; } = new List<CustomerPostageAccount>();
}

/// <summary>
/// Represents a customer postage account in the Midnight SOAP API.
/// </summary>
public class CustomerPostageAccount
{
    /// <summary>Gets or sets the postage account ID.</summary>
    public int? PostageAccountID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the account number.</summary>
    public string? AccountNumber { get; set; }
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the balance.</summary>
    public decimal? Balance { get; set; }
    /// <summary>Gets or sets the credit amount.</summary>
    public decimal? CreditAmount { get; set; }

    /// <summary>Gets or sets the raw value indicating if the postage account is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the postage account is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }
}