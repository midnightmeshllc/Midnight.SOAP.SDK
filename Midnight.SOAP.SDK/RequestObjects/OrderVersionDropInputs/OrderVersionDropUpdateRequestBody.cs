using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

/// <summary>
/// Represents the request body for updating an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionDropUpdate")]
public class OrderVersionDropUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version drop update request.
    /// </summary>
    public required OrderVersionDropUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an order version drop in the Midnight SOAP API.
/// </summary>
public class OrderVersionDropUpdateInputParameter
{
    /// <summary>Gets or sets the order version drop ID.</summary>
    public required int OrderVersionDropID { get; set; }
    /// <summary>Gets or sets the drop date.</summary>
    [XmlElement(IsNullable = true)]
    public string? DropDate { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? Quantity { get; set; }
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
    /// <summary>Gets or sets the list of user-defined fields for the drop update.</summary>
    public DropUpdateUDFList UDFList { get; set; } = new DropUpdateUDFList();
}

/// <summary>
/// Represents the list of user-defined fields for a drop update in the Midnight SOAP API.
/// </summary>
public class DropUpdateUDFList : UserDefinedFieldsFirst5
{
}