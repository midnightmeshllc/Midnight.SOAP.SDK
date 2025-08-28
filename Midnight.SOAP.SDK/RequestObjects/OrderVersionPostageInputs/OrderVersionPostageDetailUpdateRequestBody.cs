using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

/// <summary>
/// Represents the request body for updating an order version postage detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionPostageDetailUpdate")]
public class OrderVersionPostageDetailUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version postage detail update request.
    /// </summary>
    public required OrderVersionPostageDetailUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version postage detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionPostageDetailUpdateInputParameter
{
    /// <summary>Gets or sets the order version postage detail ID.</summary>
    public required int OrederVersionPostageDetailID { get; set; }
    /// <summary>Gets or sets the rate code.</summary>
    public string? RateCode { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; } = null;
    /// <summary>Gets or sets the rate.</summary>
    public decimal? Rate { get; set; } = null;
    /// <summary>Gets or sets the detail total weight.</summary>
    public decimal? DetailTotalWeight { get; set; } = null;
    /// <summary>Gets or sets the detail total postage.</summary>
    public decimal? DetailTotalPostage { get; set; } = null;
    /// <summary>Gets or sets the weight type.</summary>
    public string? WtType { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the postage is precanceled.</summary>
    public bool? Precanceled { get; set; } = null;
}