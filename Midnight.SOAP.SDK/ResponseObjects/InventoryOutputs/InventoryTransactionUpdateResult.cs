using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

[XmlRoot("Result")]
public class InventoryTransactionUpdateResult : CommonResult
{
    public int? ItemID { get; set; }
}
