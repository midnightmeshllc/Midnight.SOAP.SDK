using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for updating an inventory item lot in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryItemLotUpdate")]
public class InventoryItemLotUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory item lot update request.
    /// </summary>
    public required InventoryItemLotUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating an inventory item lot in the Midnight SOAP API.
/// </summary>
public class InventoryItemLotUpdateInputParameter
{
    /// <summary>Gets or sets the item lot to update.</summary>
    public required InventoryItemLotUpdate ItemLot { get; set; }
}

/// <summary>
/// Represents an inventory item lot update in the Midnight SOAP API.
/// </summary>
public class InventoryItemLotUpdate
{
    /// <summary>Gets or sets the item lot ID.</summary>
    public required int ItemLotID { get; set; }
    /// <summary>Gets or sets the vendor ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? VendorID { get; set; }
    /// <summary>Gets or sets the invoice number.</summary>
    [XmlElement(IsNullable = true)]
    public string? InvoiceNumber { get; set; }
    /// <summary>Gets or sets the enter date.</summary>
    [XmlElement(IsNullable = true)]
    public string? EnterDate { get; set; }
    /// <summary>Gets or sets the item cost.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? ItemCost { get; set; }
    /// <summary>Gets or sets the expiration date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ExpirationDate { get; set; }
    /// <summary>Gets or sets the weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Weight { get; set; }
    /// <summary>Gets or sets the tare weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? TareWeight { get; set; }
}