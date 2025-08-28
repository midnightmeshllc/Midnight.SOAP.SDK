using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;

/// <summary>
/// Represents the result of updating an order version inventory in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionInventoryUpdateResult : CommonResult
{
}
