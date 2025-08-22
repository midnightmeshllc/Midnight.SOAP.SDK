using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

[XmlRoot("JobCostProductionTimeEntry")]
public class ProductionTimeEntryRequestBody
{
    public required ProductionTimeEntryInputParameter InputParameter { get; set; }
}

public class ProductionTimeEntryInputParameter
{
    public required int EmployeeID { get; set; }
    public string? JobNumber { get; set; }
    public int? VersionSuffix { get; set; }
    public string? ServiceName { get; set; }
    public string? MachineName { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime StopTime { get; set; }
    public int? TotalMinutes { get; set; }
    public int? StartCount { get; set; }
    public int? StopCount { get; set; }
    public int? TotalCount { get; set; }
    public bool Rework { get; set; }
    public string? Notes { get; set; }
}