using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

[XmlRoot("JobCostServiceTimeEntryRequest")]
public class ServiceTimeEntryRequestBody
{
    [Required]
    public int EmployeeID { get; set; }
    [Required]
    public DateOnly ActivityDate { get; set; }
    public List<ServiceTimeEntryRequestItem> JobCostItems { get; set; }
}

public class ServiceTimeEntryRequestItem
{
    [Required]
    public string? OperationCode { get; set; }
    public int HelpersCount { get; set; }
    public decimal TotalTime { get; set; }
    public string? JobComment { get; set; }
    public int? OrderID { get; set; }
}