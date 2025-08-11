
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

[XmlRoot("Result")]
public class JobCostOrderVersionServiceSummaryListResult : CommonResult
{
    [XmlArray("JobCostOrders")]
    [XmlArrayItem("JobCostOrderDetail")]
    public List<JobCostOrderDetail> JobCostOrders { get; set; } = new List<JobCostOrderDetail>();
}

public class JobCostOrderDetail
{
    public string? OrderNumber { get; set; }
    public string? VersionName { get; set; }
    public string? ServiceName { get; set; }
    public DateTime? JobDate { get; set; }
    public decimal? TotalTime { get; set; }
    public int? EmployeeID { get; set; }
}