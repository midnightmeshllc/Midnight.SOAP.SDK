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
    [XmlElement(IsNullable = true)]
    public string? DropDate { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public int Quantity { get; set; }
    /// <summary>Gets or sets the drop name.</summary>
    [XmlElement(IsNullable = true)]
    public string? DropName { get; set; }
    /// <summary>Gets or sets the time due.</summary>
    [XmlElement(IsNullable = true)]
    public string? TimeDue { get; set; }
    /// <summary>Gets or sets the actual drop.</summary>
    [XmlElement(IsNullable = true)]
    public string? ActualDrop { get; set; }
    /// <summary>Gets or sets a value indicating whether the drop date is complete.</summary>
    [XmlElement(IsNullable = true)]
    public bool? DropDateComplete { get; set; }
    /// <summary>Gets or sets the postage value.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? PostageValue { get; set; }
}
