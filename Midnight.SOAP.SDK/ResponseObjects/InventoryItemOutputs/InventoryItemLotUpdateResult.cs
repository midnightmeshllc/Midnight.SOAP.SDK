
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class InventoryItemLotUpdateResult : CommonResult
{
    public int? ItemLotID { get; set; }
    public string? ItemLotNumber { get; set; }
}
