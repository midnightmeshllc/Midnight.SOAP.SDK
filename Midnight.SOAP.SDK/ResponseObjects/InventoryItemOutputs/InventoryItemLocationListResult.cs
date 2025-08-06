using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class InventoryItemLocationListResult : CommonResult
{
    [XmlArray("InventoryItemLocations")]
    [XmlArrayItem("InventoryItemLocation")]
    public List<InventoryItemLocation> InventoryItemLocations { get; set; } = new List<InventoryItemLocation>();
}

public class InventoryItemLocation
{
    public int ItemID { get; set; }
    public string? ItemCode { get; set; }
    public int? ItemLotID { get; set; }
    public string? ItemLotNumber { get; set; }
    public int? WarehouseID { get; set; }
    public string? WarehouseName { get; set; }
    public int? WarehouseLocationID { get; set; }
    public string? WarehouseLocationDescription { get; set; }
    public int? Quantity { get; set; }
}