using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of a production time entry operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ProductionTimeEntryResult : CommonResult
{
    /// <summary>
    /// Gets or sets the job cost ID for the production time entry.
    /// </summary>
    [XmlElement("JobCostID")]
    public int JobCostID { get; set; }
}
