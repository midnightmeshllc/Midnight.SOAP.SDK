using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

/// <summary>
/// Represents the request body for a service time entry in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobCostServiceTimeEntryRequest")]
public class ServiceTimeEntryRequestBody
{
    /// <summary>Gets or sets the employee ID.</summary>
    public required int EmployeeID { get; set; }
    /// <summary>Gets or sets the activity date.</summary>
    public required string ActivityDate { get; set; }
    /// <summary>Gets or sets the list of job cost items.</summary>
    public required List<ServiceTimeEntryRequestItem> JobCostItems { get; set; }
}

/// <summary>
/// Represents a service time entry request item in the Midnight SOAP API.
/// </summary>
public class ServiceTimeEntryRequestItem
{
    /// <summary>Gets or sets the operation code.</summary>
    public required string OperationCode { get; set; }
    /// <summary>Gets or sets the number of helpers.</summary>
    public required int HelpersCount { get; set; }
    /// <summary>Gets or sets the total time.</summary>
    public required decimal TotalTime { get; set; }
    /// <summary>Gets or sets the job comment.</summary>
    public string? JobComment { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
}