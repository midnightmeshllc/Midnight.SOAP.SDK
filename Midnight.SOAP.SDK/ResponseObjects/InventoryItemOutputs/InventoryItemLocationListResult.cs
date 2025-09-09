using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of an inventory item location list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryItemLocationListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of inventory item locations returned by the request.
    /// </summary>
    [XmlArray("InventoryItemLocations")]
    [XmlArrayItem("InventoryItemLocation")]
    public List<InventoryItemLocation> InventoryItemLocations { get; set; } = new List<InventoryItemLocation>();
}

/// <summary>
/// Represents an inventory item location in the Midnight SOAP API.
/// </summary>
public class InventoryItemLocation
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the item lot ID.</summary>
    public int? ItemLotID { get; set; }
    /// <summary>Gets or sets the item lot number.</summary>
    public string? ItemLotNumber { get; set; }
    /// <summary>Gets or sets the warehouse ID.</summary>
    public int? WarehouseID { get; set; }
    /// <summary>Gets or sets the warehouse name.</summary>
    public string? WarehouseName { get; set; }
    /// <summary>Gets or sets the warehouse location ID.</summary>
    public int? WarehouseLocationID { get; set; }
    /// <summary>Gets or sets the warehouse location description.</summary>
    public string? WarehouseLocationDescription { get; set; }
    /// <summary>Gets or sets the quantity at this location.</summary>
    public int? Quantity { get; set; }
}