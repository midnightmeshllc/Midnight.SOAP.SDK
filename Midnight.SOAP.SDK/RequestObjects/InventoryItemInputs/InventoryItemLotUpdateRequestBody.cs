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
    public int? VendorID { get; set; }
    public bool ShouldSerializeVendorID() => VendorID.HasValue;

    /// <summary>Gets or sets the invoice number.</summary>
    public string? InvoiceNumber { get; set; }
    public bool ShouldSerializeInvoiceNumber() => IsSet(InvoiceNumber);

    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; }
    public bool ShouldSerializeEnterDate() => IsSet(EnterDate);

    /// <summary>Gets or sets the item cost.</summary>
    public decimal? ItemCost { get; set; }
    public bool ShouldSerializeItemCost() => ItemCost.HasValue;

    /// <summary>Gets or sets the expiration date.</summary>
    public string? ExpirationDate { get; set; }
    public bool ShouldSerializeExpirationDate() => IsSet(ExpirationDate);

    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; }
    public bool ShouldSerializeWeight() => Weight.HasValue;

    /// <summary>Gets or sets the tare weight.</summary>
    public decimal? TareWeight { get; set; }
    public bool ShouldSerializeTareWeight() => TareWeight.HasValue;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}