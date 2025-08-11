
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class JobFrequencyListResult : CommonResult
{
    [XmlArray("JobFrequencies")]
    [XmlArrayItem("JobFrequency")]
    public List<JobFrequency> JobFrequencies { get; set; } = new List<JobFrequency>();
}

public class JobFrequency
{
    public int? JobFrequencyID { get; set; }
    public string? JobFrequencyDescription { get; set; }
}