
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("InventoryItemLotUpdate")]
public class InventoryItemLotUpdateRequestBody
{
    public required InventoryItemLotUpdateInputParameter InputParameter { get; set; }
}

public class InventoryItemLotUpdateInputParameter
{
    public required InventoryItemLotUpdate ItemLot { get; set; }
}

public class InventoryItemLotUpdate
{
    public required int ItemLotID { get; set; }
    public int? VendorID { get; set; } = null;
    public string? InvoiceNumber { get; set; } = null;
    public string? EnterDate { get; set; } = null;
    public decimal? ItemCost { get; set; } = null;
    public string? ExpirationDate { get; set; } = null;
    public decimal? Weight { get; set; } = null;
    public decimal? TareWeight { get; set; } = null;
}