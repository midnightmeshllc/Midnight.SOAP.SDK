using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class InventoryItemLotNewResult : CommonResult
{
    [XmlElement("ItemLotID")]
    public int ItemLotID { get; set; }
    [XmlElement("ItemLotNumber")]
    public string? ItemLotNumber { get; set; }
}
