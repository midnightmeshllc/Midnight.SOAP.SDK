using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of a service time entry operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ServiceTimeEntryResult : CommonResult
{
    /// <summary>
    /// Gets or sets the job cost ID for the service time entry.
    /// </summary>
    [XmlElement("JobCostID")]
    public int JobCostID { get; set; }
}
