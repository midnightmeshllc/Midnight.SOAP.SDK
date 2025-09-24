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
    [XmlElement(IsNullable = true)]
    public int? ServiceTypeID { get; set; }
    /// <summary>Gets or sets the priority ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? PriorityID { get; set; }
    /// <summary>Gets or sets the employee ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? EmployeeID { get; set; }
    /// <summary>Gets or sets the machine ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? MachineID { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the CSR ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CSRID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? VersionID { get; set; }
    /// <summary>Gets or sets the service ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the task start date.</summary>
    [XmlElement(IsNullable = true)]
    public string? TaskStartDate { get; set; }
    /// <summary>Gets or sets a value indicating whether to show completed tasks.</summary>
    public bool ShowCompletedTasks { get; set; } = false;
}