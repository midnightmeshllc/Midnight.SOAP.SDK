using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

/// <summary>
/// Represents the result of updating an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDetailUpdateResult : CommonResult
{
}
