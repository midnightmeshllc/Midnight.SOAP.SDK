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
    [XmlElement(IsNullable = true)]
    public string? RateCode { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? Quantity { get; set; }
    /// <summary>Gets or sets the rate.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Rate { get; set; }
    /// <summary>Gets or sets the detail total weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? DetailTotalWeight { get; set; }
    /// <summary>Gets or sets the detail total postage.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? DetailTotalPostage { get; set; }
    /// <summary>Gets or sets the weight type.</summary>
    [XmlElement(IsNullable = true)]
    public string? WtType { get; set; }
    /// <summary>Gets or sets a value indicating whether the postage is precanceled.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Precanceled { get; set; }
}