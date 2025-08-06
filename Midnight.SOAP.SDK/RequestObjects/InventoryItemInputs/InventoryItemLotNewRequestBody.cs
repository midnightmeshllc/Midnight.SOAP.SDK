using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("InventoryItemLotNew")]
public class InventoryItemLotNewRequestBody
{
    public required InventoryItemLotNewInputParameter InputParameter { get; set; }
}

public class InventoryItemLotNewInputParameter
{
    public List<ItemLot>? ItemLots { get; set; }
}

public class ItemLot
{
    public int ItemID { get; set; }
    public int VendorID { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? EnterDate { get; set; }
    public decimal ItemCost { get; set; }
    public string? ExpirationDate { get; set; }
    public decimal Weight { get; set; }
    public decimal TareWeight { get; set; }
}