
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class EmployeeListResult : CommonResult
{
    [XmlArray("Employees")]
    [XmlArrayItem("Employee")]
    public List<Employee> Employees { get; set; } = new List<Employee>();
}

public class Employee
{
    public int EmployeeID { get; set; }
    public string? EmployeeInitials { get; set; } = string.Empty;
    public string? EmployeeName { get; set; } = string.Empty;
    public string? EmployeeTitle { get; set; } = string.Empty ;
    public int? SupervisorID { get; set; }
    public string? SupervisorName { get; set; } = string.Empty;
    public string? EmployeeeHireDate { get; set; } = string.Empty;
    public int?  KioskCode {  get; set; }
    public decimal? RateWage { get; set; } = decimal.Zero;
}