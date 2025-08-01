using MidnightAPI;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.DJBInputs;

[XmlRoot("DJBList")]
public class DJBListRequestBody
{
    [Required]
    public required DJBListRequestInputParameter InputParameter { get; set; }
}

public class DJBListRequestInputParameter
{
    public int? ServiceTypeID { get; set; } = null;
    public int? PriorityID { get; set; } = null;
    public int? EmployeeID { get; set; } = null;
    public int? MachineID { get; set; } = null;
    public int? OrderID { get; set; } = null;
    public int? CSRID { get; set; } = null;
    public int? CustomerID { get; set; } = null;
    public int? VersionID { get; set; } = null;
    public int? ServiceID { get; set; } = null;
    public DateTime? TaskStartDate { get; set; } = null;
    public bool ShowCompletedTasks { get; set; } = false;
}