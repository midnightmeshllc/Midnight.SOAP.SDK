
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class WarehouseListResult : CommonResult
{
    [XmlArray("Warehouses")]
    [XmlArrayItem("Warehouse")]
    public List<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}

public class Warehouse
{
    public int? WarehouseID { get; set; }
    public string? Name { get; set; }
    public int? DefaultReceivingID { get; set; }
}