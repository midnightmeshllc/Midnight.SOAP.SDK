using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

/// <summary>
/// Represents the result of updating an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDropUpdateResult : CommonResult
{
}
