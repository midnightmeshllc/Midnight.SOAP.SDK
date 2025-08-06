
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;

[XmlRoot("Result")]
public class DJBJobStatusListResult : CommonResult
{
    [XmlArray("DJBJobStatuses")]
    [XmlArrayItem("DJBJobStatus")]
    public List<DJBJobStatus> DJBJobStatuses { get; set; } = new List<DJBJobStatus>();
}

public class DJBJobStatus
{
    [XmlElement("DJBJobStatusID")]
    public int DJBJobStatusID { get; set; }
    [XmlElement("Status")]
    public string Status { get; set; } = string.Empty;
}