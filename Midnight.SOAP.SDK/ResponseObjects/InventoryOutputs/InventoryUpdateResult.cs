
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class InventoryUpdateResult : CommonResult
{
    public int? ItemID { get; set; }
}
