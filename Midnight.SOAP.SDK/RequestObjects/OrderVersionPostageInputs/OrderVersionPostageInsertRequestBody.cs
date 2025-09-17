using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for inserting an order version postage in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageInsert")]
public class OrderVersionPostageInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage insert request.
    /// </summary>
    public required OrderVersionPostageInsertInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for inserting an order version postage in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageInsertInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public int VersionID { get; set; }
    /// <summary>Gets or sets the postage affix name.</summary>
    public string PostageAffixName { get; set; } = string.Empty;
    /// <summary>Gets or sets the postage quantity.</summary>
    public int PostageQuantity { get; set; }
    /// <summary>Gets or sets the postage rate.</summary>
    public decimal PostageRate { get; set; }
    /// <summary>Gets or sets the postage total.</summary>
    public decimal PostageTotal { get; set; }
    /// <summary>Gets or sets the date used.</summary>
    public string DateUsed { get; set; } = string.Empty;
    /// <summary>Gets or sets the mail class ID.</summary>
    public int MailClassID { get; set; }
    /// <summary>Gets or sets the total weight.</summary>
    public decimal? TotalWeight { get; set; } = null;
    /// <summary>Gets or sets the postage markup type.</summary>
    public string? PostageMarkupType { get; set; } = null;
    /// <summary>Gets or sets the postage markup value.</summary>
    public decimal? PostageMarkupValue { get; set; } = null;
    /// <summary>Gets or sets the postage sell rate.</summary>
    public decimal? PostageSellRate { get; set; } = null;
}
