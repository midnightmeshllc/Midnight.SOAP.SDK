
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class InventoryNewResult : CommonResult
{
    [XmlElement("ItemID")]
    public int ItemID { get; set; }
    [XmlElement("ItemCode")]
    public DateTime? CreateDateTime { get; set; }
}
