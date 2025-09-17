using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

/// <summary>
/// Represents the request body for a production time entry in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobCostProductionTimeEntry")]
public class ProductionTimeEntryRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the production time entry request.
    /// </summary>
    public required ProductionTimeEntryInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for a production time entry in the Midnight SOAP API.
/// </summary>
public class ProductionTimeEntryInputParameter
{
    /// <summary>Gets or sets the employee ID.</summary>
    public required int EmployeeID { get; set; }
    /// <summary>Gets or sets the job number.</summary>
    public string? JobNumber { get; set; } = null;
    /// <summary>Gets or sets the version suffix.</summary>
    public int? VersionSuffix { get; set; } = null;
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; } = null;
    /// <summary>Gets or sets the machine name.</summary>
    public string? MachineName { get; set; } = null;
    /// <summary>Gets or sets the start time.</summary>
    public DateTime StartTime { get; set; }
    /// <summary>Gets or sets the stop time.</summary>
    public DateTime StopTime { get; set; }
    /// <summary>Gets or sets the total minutes.</summary>
    public int? TotalMinutes { get; set; } = null;
    /// <summary>Gets or sets the start count.</summary>
    public int? StartCount { get; set; } = null;
    /// <summary>Gets or sets the stop count.</summary>
    public int? StopCount { get; set; } = null;
    /// <summary>Gets or sets the total count.</summary>
    public int? TotalCount { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether this is a rework.</summary>
    public bool Rework { get; set; } = false;
    /// <summary>Gets or sets the notes.</summary>
    public string? Notes { get; set; } = null;
}