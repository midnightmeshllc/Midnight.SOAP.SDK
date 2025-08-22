using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

[XmlRoot("JobCostServiceTimeEntryRequest")]
public class ServiceTimeEntryRequestBody
{
    public required int EmployeeID { get; set; }
    public required string ActivityDate { get; set; }
    public required List<ServiceTimeEntryRequestItem> JobCostItems { get; set; }
}

public class ServiceTimeEntryRequestItem
{
    public required string OperationCode { get; set; }
    public required int HelpersCount { get; set; }
    public required decimal TotalTime { get; set; }
    public string? JobComment { get; set; }
    public int? OrderID { get; set; }
}