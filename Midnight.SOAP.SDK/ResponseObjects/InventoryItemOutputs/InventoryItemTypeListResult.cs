using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of an inventory item type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryItemTypeListResult :CommonResult
{
    /// <summary>
    /// Gets or sets the list of inventory item types returned by the request.
    /// </summary>
    [XmlArray("InventoryItemTypes")]
    [XmlArrayItem("InventoryItemType")]
    public List<InventoryItemType> InventoryItemTypes { get; set; } = new List<InventoryItemType>();
}

/// <summary>
/// Represents an inventory item type in the Midnight SOAP API.
/// </summary>
public class InventoryItemType
{
    /// <summary>Gets or sets the item type name.</summary>
    public string? ItemTypeName { get; set; }
    /// <summary>Gets or sets the item type description.</summary>
    public string? ItemTypeDescription { get; set; }
}