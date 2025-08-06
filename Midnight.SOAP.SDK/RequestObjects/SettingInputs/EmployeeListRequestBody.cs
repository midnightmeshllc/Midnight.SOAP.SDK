
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("EmployeeList")]
public class EmployeeListRequestBody
{
    public required EmployeeListInputParameter InputParameter { get; set; }
}

public class EmployeeListInputParameter
{
    public int? EmployeeID { get; set; }
    public string? EmployeeInitials { get; set; }
    public string? EmployeeName { get; set; }
    public bool Active { get; set; } = true;
}