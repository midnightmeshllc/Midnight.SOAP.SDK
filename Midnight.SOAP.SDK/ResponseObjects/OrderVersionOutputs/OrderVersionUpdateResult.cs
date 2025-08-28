using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

/// <summary>
/// Represents the result of updating an order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionUpdateResult : CommonResult
{
}
