using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;

[XmlRoot("Result")]
public class DJBListResult : CommonResult
{
    [XmlArray("DJBList")]
    [XmlArrayItem("Record")]
    public List<Record> DJBList { get; set; } = new List<Record>();
}

public class Record
{
    [XmlElement("DJBDetailID")]
    public int DJBDetailID { get; set; }
    [XmlElement("Priority")]
    public int? Priority { get; set; }
    [XmlElement("Employee")]
    public string? Employee { get; set; }
    [XmlElement("EmployeeID")]
    public int? EmployeeID { get; set; }
    [XmlElement("Equipment")]
    public string? Equipment { get; set; }
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
    [XmlElement("CSR")]
    public string? CSR { get; set; }
    [XmlElement("Customer")]
    public string? Customer { get; set; }
    [XmlElement("Version")]
    public string? Version { get; set; }
    [XmlElement("OrderVersionDetailID")]
    public int? OrderVersionDetailID { get; set; }
    [XmlElement("ServiceDescription")]
    public string? ServiceDescription { get; set; }
    [XmlElement("EstimatedTime")]
    public decimal? EstimatedTime { get; set; }
    [XmlElement("ActualTime")]
    public decimal? ActualTime { get; set; }
    [XmlElement("TaskStart")]
    public DateTime? TaskStart { get; set; }
    [XmlElement("JobDue")]
    public DateTime? JobDue { get; set; }
    [XmlElement("TimeDue")]
    public DateTime? TimeDue { get; set; }
    [XmlElement("DJBStatus")]
    public string? DJBStatus { get; set; }
    [XmlElement("Task")]
    public string? Task { get; set; }
    [XmlElement("Quantity")]
    public decimal? Quantity { get; set; }
    [XmlElement("RunRate")]
    public decimal? RunRate { get; set; }
    [XmlElement("OrderDate")]
    public DateTime? OrderDate { get; set; }
    [XmlElement("MaterialInDate")]
    public DateTime? MaterialInDate { get; set; }
    [XmlElement("ArtworkInDate")]
    public DateTime? ArtworkInDate { get; set; }
    [XmlElement("ItemDescription")]
    public string? ItemDescription { get; set; }
    [XmlElement("DroppedShippedDate")]
    public DateTime? DroppedShippedDate { get; set; }
    [XmlElement("PONum")]
    public string? PONum { get; set; }
    [XmlElement("CSRInitials")]
    public string? CSRInitials { get; set; }
    [XmlElement("SalesRep")]
    public string? SalesRep { get; set; }
    [XmlElement("ContactName")]
    public string? ContactName { get; set; }
}