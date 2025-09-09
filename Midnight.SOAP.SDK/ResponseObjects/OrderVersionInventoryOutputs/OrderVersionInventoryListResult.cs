using Midnight.SOAP.SDK.CommonObjects;
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;

/// <summary>
/// Represents the result of a list request for order version inventory in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionInventoryListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order version inventory records returned by the request.
    /// </summary>
    [XmlArray("OrderVersionInventorys")]
    [XmlArrayItem("OrderVersionInventory")]
    public List<OrderVersionInventory> OrderVersionInventorys { get; set; } = new List<OrderVersionInventory>();
}

/// <summary>
/// Represents an order version inventory record in the Midnight SOAP API.
/// </summary>
public class OrderVersionInventory
{
    /// <summary>Gets or sets the order inventory ID.</summary>
    public int? OrderInventoryID { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; }
    /// <summary>Gets or sets the description of the inventory item.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the quantity needed.</summary>
    public decimal? QuantityNeeded { get; set; }
    /// <summary>Gets or sets the notes for the inventory record.</summary>
    public string? Notes { get; set; }
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; }
}