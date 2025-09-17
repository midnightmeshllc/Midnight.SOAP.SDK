using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing employees in the Midnight SOAP API.
/// </summary>
[XmlRoot("EmployeeList")]
public class EmployeeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the employee list request.
    /// </summary>
    public required EmployeeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing employees in the Midnight SOAP API.
/// </summary>
public class EmployeeListInputParameter
{
    /// <summary>Gets or sets the employee ID.</summary>
    public int? EmployeeID { get; set; } = null;
    /// <summary>Gets or sets the employee initials.</summary>
    public string? EmployeeInitials { get; set; } = null;
    /// <summary>Gets or sets the employee name.</summary>
    public string? EmployeeName { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the employee is active.</summary>
    public bool Active { get; set; } = true;
}