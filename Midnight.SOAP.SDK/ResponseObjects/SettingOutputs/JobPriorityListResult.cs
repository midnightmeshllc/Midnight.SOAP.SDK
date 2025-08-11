
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class JobPriorityListResult : CommonResult
{
    [XmlArray("JobPriorities")]
    [XmlArrayItem("JobPriority")]
    public List<JobPriority> JobPriorities { get; set; } = new List<JobPriority>();
}

public class JobPriority
{
    public int? JobPriorityID { get; set; }
    public string? JobPriorityDescription { get; set; }
}