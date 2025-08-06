

using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;

[XmlRoot("Result")]
public class PurchaseOrderNewResult : CommonResult
{
    [XmlElement("PurchaseOrderID")]
    public int PurchaseOrderID { get; set; }
}
