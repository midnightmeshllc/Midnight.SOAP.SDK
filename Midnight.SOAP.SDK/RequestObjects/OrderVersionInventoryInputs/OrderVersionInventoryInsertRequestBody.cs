using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

/// <summary>
/// Represents the request body for inserting an order version inventory in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionInventoryInsert")]
public class OrderVersionInventoryInsertRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version inventory insert request.
    /// </summary>
    public required OrderVersionInventoryInsertInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for inserting an order version inventory in the Midnight SOAP API.
/// </summary>
public class OrderVersionInventoryInsertInputParameter
{
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
    /// <summary>Gets or sets the item ID.</summary>
    public required int ItemID { get; set; }
    /// <summary>Gets or sets the description.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
    /// <summary>Gets or sets the quantity needed.</summary>
    public int QuantityNeeded { get; set; }
    /// <summary>Gets or sets the priority.</summary>
    [XmlElement(IsNullable = true)]
    public int? Priority { get; set; }
    /// <summary>Gets or sets the notes.</summary>
    [XmlElement(IsNullable = true)]
    public string? Notes { get; set; }
}