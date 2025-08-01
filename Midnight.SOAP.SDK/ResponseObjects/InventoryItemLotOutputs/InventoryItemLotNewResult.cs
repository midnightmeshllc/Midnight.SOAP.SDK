
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemLotOutputs;

[XmlRoot("Result")]
public class InventoryItemLotNewResult : CommonResult
{
    public int ItemLotID { get; set; }
    public string? ItemLotNumber { get; set; }
}
