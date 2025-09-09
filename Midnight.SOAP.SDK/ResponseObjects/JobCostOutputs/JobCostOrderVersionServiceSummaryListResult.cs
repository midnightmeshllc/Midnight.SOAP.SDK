using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of a job cost order version service summary list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobCostOrderVersionServiceSummaryListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of job cost order details returned by the request.
    /// </summary>
    [XmlArray("JobCostOrders")]
    [XmlArrayItem("JobCostOrderDetail")]
    public List<JobCostOrderDetail> JobCostOrders { get; set; } = new List<JobCostOrderDetail>();
}

/// <summary>
/// Represents a job cost order detail in the Midnight SOAP API.
/// </summary>
public class JobCostOrderDetail
{
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the version name.</summary>
    public string? VersionName { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; }
    /// <summary>Gets or sets the job date.</summary>
    public DateTime? JobDate { get; set; }
    /// <summary>Gets or sets the total time.</summary>
    public decimal? TotalTime { get; set; }
    /// <summary>Gets or sets the employee ID.</summary>
    public int? EmployeeID { get; set; }
}