using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;

/// <summary>
/// Represents the result of a DJB list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class DJBListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of DJB records returned by the request.
    /// </summary>
    [XmlArray("DJBList")]
    [XmlArrayItem("Record")]
    public List<Record> DJBList { get; set; } = new List<Record>();
}

/// <summary>
/// Represents a DJB record in the Midnight SOAP API.
/// </summary>
public class Record
{
    /// <summary>Gets or sets the DJB detail ID.</summary>
    [XmlElement("DJBDetailID")]
    public int DJBDetailID { get; set; }
    /// <summary>Gets or sets the priority.</summary>
    [XmlElement("Priority")]
    public int? Priority { get; set; }
    /// <summary>Gets or sets the employee name.</summary>
    [XmlElement("Employee")]
    public string? Employee { get; set; }
    /// <summary>Gets or sets the employee ID.</summary>
    [XmlElement("EmployeeID")]
    public int? EmployeeID { get; set; }
    /// <summary>Gets or sets the equipment name.</summary>
    [XmlElement("Equipment")]
    public string? Equipment { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the CSR name.</summary>
    [XmlElement("CSR")]
    public string? CSR { get; set; }
    /// <summary>Gets or sets the customer name.</summary>
    [XmlElement("Customer")]
    public string? Customer { get; set; }
    /// <summary>Gets or sets the version.</summary>
    [XmlElement("Version")]
    public string? Version { get; set; }
    /// <summary>Gets or sets the order version detail ID.</summary>
    [XmlElement("OrderVersionDetailID")]
    public int? OrderVersionDetailID { get; set; }
    /// <summary>Gets or sets the service description.</summary>
    [XmlElement("ServiceDescription")]
    public string? ServiceDescription { get; set; }
    /// <summary>Gets or sets the estimated time.</summary>
    [XmlElement("EstimatedTime")]
    public decimal? EstimatedTime { get; set; }
    /// <summary>Gets or sets the actual time.</summary>
    [XmlElement("ActualTime")]
    public decimal? ActualTime { get; set; }
    /// <summary>Gets or sets the task start date and time.</summary>
    [XmlElement("TaskStart")]
    public DateTime? TaskStart { get; set; }
    /// <summary>Gets or sets the job due date and time.</summary>
    [XmlElement("JobDue")]
    public DateTime? JobDue { get; set; }
    /// <summary>Gets or sets the time due.</summary>
    [XmlElement("TimeDue")]
    public DateTime? TimeDue { get; set; }
    /// <summary>Gets or sets the DJB status.</summary>
    [XmlElement("DJBStatus")]
    public string? DJBStatus { get; set; }
    /// <summary>Gets or sets the task name.</summary>
    [XmlElement("Task")]
    public string? Task { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    [XmlElement("Quantity")]
    public decimal? Quantity { get; set; }
    /// <summary>Gets or sets the run rate.</summary>
    [XmlElement("RunRate")]
    public decimal? RunRate { get; set; }
    /// <summary>Gets or sets the order date.</summary>
    [XmlElement("OrderDate")]
    public DateTime? OrderDate { get; set; }
    /// <summary>Gets or sets the material in date.</summary>
    [XmlElement("MaterialInDate")]
    public DateTime? MaterialInDate { get; set; }
    /// <summary>Gets or sets the artwork in date.</summary>
    [XmlElement("ArtworkInDate")]
    public DateTime? ArtworkInDate { get; set; }
    /// <summary>Gets or sets the item description.</summary>
    [XmlElement("ItemDescription")]
    public string? ItemDescription { get; set; }
    /// <summary>Gets or sets the dropped shipped date.</summary>
    [XmlElement("DroppedShippedDate")]
    public DateTime? DroppedShippedDate { get; set; }
    /// <summary>Gets or sets the PO number.</summary>
    [XmlElement("PONum")]
    public string? PONum { get; set; }
    /// <summary>Gets or sets the CSR initials.</summary>
    [XmlElement("CSRInitials")]
    public string? CSRInitials { get; set; }
    /// <summary>Gets or sets the sales representative name.</summary>
    [XmlElement("SalesRep")]
    public string? SalesRep { get; set; }
    /// <summary>Gets or sets the contact name.</summary>
    [XmlElement("ContactName")]
    public string? ContactName { get; set; }
}