using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of an inventory item lot list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryItemLotListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of inventory item lots returned by the request.
    /// </summary>
    [XmlArray("ItemLots")]
    [XmlArrayItem("ItemLot")]
    public List<InventoryItemLot> ItemLots { get; set; } = new List<InventoryItemLot>();
}

/// <summary>
/// Represents an inventory item lot in the Midnight SOAP API.
/// </summary>
public class InventoryItemLot
{
    /// <summary>Gets or sets the item lot ID.</summary>
    public int? ItemLotID { get; set; }
    /// <summary>Gets or sets the item lot number.</summary>
    public string? ItemLotNumber { get; set; }
    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; }
    /// <summary>Gets or sets the vendor ID.</summary>
    public int? VendorID { get; set; }
    /// <summary>Gets or sets the vendor name.</summary>
    public string? VendorName { get; set; }
    /// <summary>Gets or sets the invoice number.</summary>
    public string? InvoiceNumber { get; set; }
    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; }
    /// <summary>Gets or sets the item cost.</summary>
    public decimal? ItemCost { get; set; }
    /// <summary>Gets or sets the expiration date.</summary>
    public string? ExpirationDate { get; set; }

    /// <summary>Gets or sets the raw value indicating if the item lot is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }
    /// <summary>Gets a value indicating whether the item lot is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }

    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; }
    /// <summary>Gets or sets the tare weight.</summary>
    public decimal? TareWeight { get; set; }
}