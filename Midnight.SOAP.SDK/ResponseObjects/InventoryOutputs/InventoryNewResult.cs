
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class InventoryNewResult : CommonResult
{
    public int ItemID { get; set; }
    public DateTime? CreateDateTime { get; set; }
}
