using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class JobTypeListResult : CommonResult
{
    [XmlArray("JobTypes")]
    [XmlArrayItem("JobType")]
    public List<JobType> JobTypes { get; set; } = new List<JobType>();
}

public class JobType
{
    public int? JobTypeID { get; set; }
    public string? JobTypeDescription { get; set; }
}