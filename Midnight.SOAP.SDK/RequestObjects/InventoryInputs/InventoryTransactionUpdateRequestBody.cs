using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

/// <summary>
/// Represents the request body for updating an inventory transaction in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryTransactionUpdate")]
public class InventoryTransactionUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory transaction update request.
    /// </summary>
    public required InventoryTransactionUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an inventory transaction in the Midnight SOAP API.
/// </summary>
public class InventoryTransactionUpdateInputParameter
{
    /// <summary>Gets or sets the inventory transaction update item.</summary>
    public required InventoryTransactionUpdateItem Item { get; set; }
}

/// <summary>
/// Represents an inventory transaction update item in the Midnight SOAP API.
/// </summary>
public class InventoryTransactionUpdateItem
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the item transaction type ID.</summary>
    public int ItemTransactionTypeID { get; set; }
    /// <summary>Gets or sets the source warehouse location ID.</summary>
    public int? FromWarehouseLocationID { get; set; } = null;
    /// <summary>Gets or sets the destination warehouse location ID.</summary>
    public int? ToWarehouseLocationID { get; set; } = null;
    /// <summary>Gets or sets the quantity.</summary>
    public int? Quantity { get; set; } = null;
    /// <summary>Gets or sets the lot ID.</summary>
    public int? LotID { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the reason code ID.</summary>
    public int? ReasonCodeID { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
}