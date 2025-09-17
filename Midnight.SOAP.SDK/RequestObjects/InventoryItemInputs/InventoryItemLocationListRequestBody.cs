using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for listing inventory item locations in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryItemLocationList")]
public class InventoryItemLocationListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory item location list request.
    /// </summary>
    public required InventoryItemLocationListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing inventory item locations in the Midnight SOAP API.
/// </summary>
public class InventoryItemLocationListInputParameter
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the item lot ID.</summary>
    public int ItemLotID { get; set; }
    /// <summary>Gets or sets the warehouse ID.</summary>
    public int? WarehouseID { get; set; } = null;
    /// <summary>Gets or sets the warehouse location ID.</summary>
    public int? WarehouseLocationID { get; set; } = null;
}