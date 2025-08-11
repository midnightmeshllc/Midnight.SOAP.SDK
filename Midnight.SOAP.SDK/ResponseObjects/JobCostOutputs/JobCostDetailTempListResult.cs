
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

[XmlRoot("Result")]
public class JobCostDetailTempListResult : CommonResult
{
    [XmlArray("JobCostDetailsTemp")]
    [XmlArrayItem("JobCostDetailTemp")]
    public List<JobCostDetailTemp> JobCostDetailsTemp { get; set; } = new List<JobCostDetailTemp>();
}

public class JobCostDetailTemp
{
    public int JobCostDetailTempID { get; set; }
    public int JobCostTempID { get; set; }
    public int OrderID { get; set; }
    public string? OrderNumber { get; set; }
    public string? ProjectName { get; set; }
    public int? VersionID { get; set; }
    public string? VersionName { get; set; }
    public int? CustomerID { get; set; }
    public string? CustomerName { get; set; }
    public int? ServiceID { get; set; }
    public string? ServiceName { get; set; }
    public int? ShiftID { get; set; }
    public string? ShiftName { get; set; }
    public int? MachineID { get; set; }
    public string? MachineName { get; set; }
    public DateTime? JobDate { get; set; }
    public TimeOnly? StartTime { get; set; }
    public string? EmployeeFirstName { get; set; }
    public string? EmployeeLastName { get; set; }
}