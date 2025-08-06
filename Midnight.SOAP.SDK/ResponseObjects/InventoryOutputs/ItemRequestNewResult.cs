using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class ItemRequestNewResult : CommonResult
{
    [XmlElement("ItemRequestID")]
    public int ItemRequestID { get; set; }
}
