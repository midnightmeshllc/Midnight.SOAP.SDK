using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of updating an order version other job cost in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionOtherJobCostUpdateResult : CommonResult
{
}
