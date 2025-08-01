
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class ItemRequestNewResult : CommonResult
{
    public int ItemRequestID { get; set; }
}
