

using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;

[XmlRoot("Result")]
public class PurchaseOrderNewResult : CommonResult
{
    public int PurchaseOrderID { get; set; }
}
