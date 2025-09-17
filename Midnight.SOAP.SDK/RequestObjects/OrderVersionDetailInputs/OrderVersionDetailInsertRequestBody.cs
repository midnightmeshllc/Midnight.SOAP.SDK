using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

/// <summary>
/// Represents the request body for inserting an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDetailInsert")]
public class OrderVersionDetailInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version detail insert.
    /// </summary>
    public required OrderVersionDetailInsertInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameters for inserting an order version detail.
/// </summary>
public class OrderVersionDetailInsertInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the version ID.</summary>
    public int VersionID { get; set; }
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; } = null;
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; } = null;
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the detail is taxable.</summary>
    public bool Taxable { get; set; } = false;
    /// <summary>Gets or sets the priority.</summary>
    public int? Priority { get; set; } = null;
    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? ServiceHyperlink { get; set; } = null;
    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
}