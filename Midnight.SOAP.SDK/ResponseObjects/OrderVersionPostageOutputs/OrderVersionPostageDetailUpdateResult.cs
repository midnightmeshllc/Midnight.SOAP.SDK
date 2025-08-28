using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

/// <summary>
/// Represents the result of updating an order version postage detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionPostageDetailUpdateResult : CommonResult
{
}
