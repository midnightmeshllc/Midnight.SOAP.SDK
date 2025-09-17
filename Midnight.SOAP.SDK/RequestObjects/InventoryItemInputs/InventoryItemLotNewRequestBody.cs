using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for creating a new inventory item lot in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryItemLotNew")]
public class InventoryItemLotNewRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory item lot new request.
    /// </summary>
    public required InventoryItemLotNewInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for creating a new inventory item lot in the Midnight SOAP API.
/// </summary>
public class InventoryItemLotNewInputParameter
{
    /// <summary>Gets or sets the list of item lots.</summary>
    public List<ItemLot>? ItemLots { get; set; }
}

/// <summary>
/// Represents an item lot for inventory in the Midnight SOAP API.
/// </summary>
public class ItemLot
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
    /// <summary>Gets or sets the vendor ID.</summary>
    public int VendorID { get; set; }
    /// <summary>Gets or sets the invoice number.</summary>
    public string? InvoiceNumber { get; set; } = null;
    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; } = null;
    /// <summary>Gets or sets the item cost.</summary>
    public decimal? ItemCost { get; set; } = null;
    /// <summary>Gets or sets the expiration date.</summary>
    public string? ExpirationDate { get; set; } = null;
    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; } = null;
    /// <summary>Gets or sets the tare weight.</summary>
    public decimal? TareWeight { get; set; } = null;
}