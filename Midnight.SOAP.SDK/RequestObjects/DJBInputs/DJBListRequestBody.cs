using MidnightAPI;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.DJBInputs;

/// <summary>
/// Represents the request body for listing DJB records in the Midnight SOAP API.
/// </summary>
[XmlRoot("DJBList")]
public class DJBListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the DJB list request.
    /// </summary>
    public required DJBListRequestInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing DJB records in the Midnight SOAP API.
/// </summary>
public class DJBListRequestInputParameter
{
    /// <summary>Gets or sets the service type ID.</summary>
    public int? ServiceTypeID { get; set; } = null;
    /// <summary>Gets or sets the priority ID.</summary>
    public int? PriorityID { get; set; } = null;
    /// <summary>Gets or sets the employee ID.</summary>
    public int? EmployeeID { get; set; } = null;
    /// <summary>Gets or sets the machine ID.</summary>
    public int? MachineID { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the CSR ID.</summary>
    public int? CSRID { get; set; } = null;
    /// <summary>Gets or sets the customer ID.</summary>
    public int? CustomerID { get; set; } = null;
    /// <summary>Gets or sets the version ID.</summary>
    public int? VersionID { get; set; } = null;
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; } = null;
    /// <summary>Gets or sets the task start date.</summary>
    public string? TaskStartDate { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether to show completed tasks.</summary>
    public bool ShowCompletedTasks { get; set; } = false;
}