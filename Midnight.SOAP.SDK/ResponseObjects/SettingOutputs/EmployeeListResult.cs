using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of an employee list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class EmployeeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of employees returned by the request.
    /// </summary>
    [XmlArray("Employees")]
    [XmlArrayItem("Employee")]
    public List<Employee> Employees { get; set; } = new List<Employee>();
}

/// <summary>
/// Represents an employee in the Midnight SOAP API.
/// </summary>
public class Employee
{
    /// <summary>Gets or sets the employee ID.</summary>
    public int EmployeeID { get; set; }
    /// <summary>Gets or sets the employee initials.</summary>
    public string? EmployeeInitials { get; set; }
    /// <summary>Gets or sets the employee name.</summary>
    public string? EmployeeName { get; set; }
    /// <summary>Gets or sets the employee title.</summary>
    public string? EmployeeTitle { get; set; }

    /// <summary>Gets or sets the raw XML value of the supervisor ID.</summary>
    [XmlElement("SupervisorID", IsNullable = true)]
    public string? SupervisorIDRaw { get; set; }

    /// <summary>Gets or sets the supervisor ID. Returns null if the XML value is empty or cannot be parsed.</summary>
    [XmlIgnore]
    public int? SupervisorID
    {
        get
        {
            if (string.IsNullOrWhiteSpace(SupervisorIDRaw))
                return null;
            if (int.TryParse(SupervisorIDRaw, out var result))
                return result;
            return null;
        }
        set
        {
            SupervisorIDRaw = value?.ToString();
        }
    }

    /// <summary>Gets or sets the supervisor name.</summary>
    public string? SupervisorName { get; set; }
    /// <summary>Gets or sets the employee hire date.</summary>
    public string? EmployeeeHireDate { get; set; }
    /// <summary>Gets or sets the kiosk code.</summary>
    public int? KioskCode { get; set; }
    /// <summary>Gets or sets the wage rate.</summary>
    public decimal? RateWage { get; set; }
}