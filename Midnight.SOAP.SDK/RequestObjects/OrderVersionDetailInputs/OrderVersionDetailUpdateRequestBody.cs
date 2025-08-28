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
    public string? ServiceName { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public decimal? Quantity { get; set; } = null;
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; } = null;
    /// <summary>Gets or sets the run rate.</summary>
    public decimal? RunRate { get; set; } = null;
    /// <summary>Gets or sets the setup time.</summary>
    public decimal? SetupTime { get; set; } = null;
    /// <summary>Gets or sets the quantity done.</summary>
    public int? QtyDone { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the detail is complete.</summary>
    public bool? Complete { get; set; } = null;
    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? ServiceHyperlink { get; set; } = null;
    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
}