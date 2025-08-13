
using Midnight.SOAP.SDK.CommonObjects;
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;

[XmlRoot("Result")]
public class OrderVersionInventoryListResult : CommonResult
{
    [XmlArray("OrderVersionInventorys")]
    [XmlArrayItem("OrderVersionInventory")]
    public List<OrderVersionInventory> OrderVersionInventorys { get; set; } = new List<OrderVersionInventory>();
}

public class OrderVersionInventory
{
    public int? OrderInventoryID { get; set; }
    public int? OrderID { get; set; }
    public int? VersionID { get; set; }
    public int? ItemID { get; set; }
    public string? Description { get; set; }
    public decimal? QuantityNeeded { get; set; }
    public string? Notes { get; set; }
    public string? ItemCode { get; set; }
}