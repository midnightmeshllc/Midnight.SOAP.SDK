using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of a temporary job cost detail list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class JobCostDetailTempListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of temporary job cost details returned by the request.
    /// </summary>
    [XmlArray("JobCostDetailsTemp")]
    [XmlArrayItem("JobCostDetailTemp")]
    public List<JobCostDetailTemp> JobCostDetailsTemp { get; set; } = new List<JobCostDetailTemp>();
}

/// <summary>
/// Represents a temporary job cost detail in the Midnight SOAP API.
/// </summary>
public class JobCostDetailTemp
{
    /// <summary>Gets or sets the job cost detail temp ID.</summary>
    public int JobCostDetailTempID { get; set; }
    /// <summary>Gets or sets the job cost temp ID.</summary>
    public int JobCostTempID { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int OrderID { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the version name.</summary>
    public string? VersionName { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    public string? CustomerName { get; set; }
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; }
    /// <summary>Gets or sets the shift ID.</summary>
    public int? ShiftID { get; set; }
    /// <summary>Gets or sets the shift name.</summary>
    public string? ShiftName { get; set; }
    /// <summary>Gets or sets the machine ID.</summary>
    public int? MachineID { get; set; }
    /// <summary>Gets or sets the machine name.</summary>
    public string? MachineName { get; set; }
    /// <summary>Gets or sets the job date.</summary>
    public DateTime? JobDate { get; set; }
    /// <summary>Gets or sets the start time.</summary>
    public TimeOnly? StartTime { get; set; }
    /// <summary>Gets or sets the employee's first name.</summary>
    public string? EmployeeFirstName { get; set; }
    /// <summary>Gets or sets the employee's last name.</summary>
    public string? EmployeeLastName { get; set; }
}