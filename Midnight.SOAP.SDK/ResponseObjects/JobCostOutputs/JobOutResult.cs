using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of a job out operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobOutResult : CommonResult
{
}
