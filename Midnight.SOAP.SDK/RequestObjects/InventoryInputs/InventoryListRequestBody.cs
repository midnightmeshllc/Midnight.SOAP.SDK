using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

/// <summary>
/// Represents the request body for listing inventory in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryList")]
public class InventoryListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory list request.
    /// </summary>
    public required InventoryListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing inventory in the Midnight SOAP API.
/// </summary>
public class InventoryListInputParameter
{
    /// <summary>Gets or sets the list of inventory items.</summary>
    public required List<InventoryListItem> Item { get; set; }
}

/// <summary>
/// Represents an inventory item for the inventory list request in the Midnight SOAP API.
/// </summary>
public class InventoryListItem
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; } = null;
    /// <summary>Gets or sets the item type name.</summary>
    public string? ItemTypeName { get; set; } = null;
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; } = null;
    /// <summary>Gets or sets the item name.</summary>
    public string? ItemName { get; set; } = null;
    /// <summary>Gets or sets the item description.</summary>
    public string? ItemDescription { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the item is active.</summary>
    public bool? Active { get; set; } = null;
}