using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

/// <summary>
/// Represents the request body for inserting an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDropInsert")]
public class OrderVersionDropInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version drop insert request.
    /// </summary>
    public required OrderVersionDropInsertInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for inserting an order version drop in the Midnight SOAP API.
/// </summary>
public class OrderVersionDropInsertInputParameter : UserDefinedFieldsFirst5
{
    /// <summary>Gets or sets the version ID.</summary>
    public int VersionID { get; set; }
    /// <summary>Gets or sets the drop date.</summary>
    public string? DropDate { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public int Quantity { get; set; }
    /// <summary>Gets or sets the drop name.</summary>
    public string? DropName { get; set; } = null;
    /// <summary>Gets or sets the time due.</summary>
    public string? TimeDue { get; set; } = null;
    /// <summary>Gets or sets the actual drop.</summary>
    public string? ActualDrop { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the drop date is complete.</summary>
    public bool? DropDateComplete { get; set; } = false;
    /// <summary>Gets or sets the postage value.</summary>
    public decimal? PostageValue { get; set; } = null;

}
