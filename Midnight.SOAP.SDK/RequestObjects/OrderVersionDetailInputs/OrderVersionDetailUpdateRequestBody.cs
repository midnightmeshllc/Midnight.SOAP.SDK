using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the request body for updating an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDetailUpdate")]
public class OrderVersionDetailUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version detail update request.
    /// </summary>
    public required OrderVersionDetailUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version detail in the Midnight SOAP API.
/// </summary>
public class OrderVersionDetailUpdateInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the order version detail ID.</summary>
    public required int OrderVersionDetailID { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceName { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Quantity { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the run rate.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? RunRate { get; set; }
    /// <summary>Gets or sets the setup time.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? SetupTime { get; set; }
    /// <summary>Gets or sets the quantity done.</summary>
    [XmlElement(IsNullable = true)]
    public int? QtyDone { get; set; }
    /// <summary>Gets or sets a value indicating whether the detail is complete.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Complete { get; set; }
    /// <summary>Gets or sets the service hyperlink.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceHyperlink { get; set; }
    /// <summary>Gets or sets the file location.</summary>
    [XmlElement(IsNullable = true)]
    public string? FileLocation { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    [XmlElement(IsNullable = true)]
    public string? Comment { get; set; }
}