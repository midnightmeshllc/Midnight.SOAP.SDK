
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class InventoryItemLotListResult : CommonResult
{
    [XmlArray("ItemLots")]
    [XmlArrayItem("ItemLot")]
    public List<InventoryItemLot> ItemLots { get; set; } = new List<InventoryItemLot>();
}

public class InventoryItemLot
{
    public int? ItemLotID { get; set; }
    public string? ItemLotNumber { get; set; }
    public int? ItemID { get; set; }
    public int? VendorID { get; set; }
    public string? VendorName { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? EnterDate { get; set; }
    public decimal? ItemCost { get; set; }
    public string? ExpirationDate { get; set; }

    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }
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

    public decimal? Weight { get; set; }
    public decimal? TareWeight { get; set; }
}