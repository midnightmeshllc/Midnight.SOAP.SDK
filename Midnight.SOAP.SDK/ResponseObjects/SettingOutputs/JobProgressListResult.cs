
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class JobProgressListResult : CommonResult
{
    [XmlArray("JobProgressList")]
    [XmlArrayItem("JobProgress")]
    public List<JobProgress> JobProgressList { get; set; } = new List<JobProgress>();
}

public class JobProgress
{
    public string? JobProgressCode { get; set; }
    public string? JobProgressName { get; set; }
    public int? JobProgressSort { get; set; }
}