
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class RecordResolutionListResult : CommonResult
{
    [XmlArray("RecordResolutions")]
    [XmlArrayItem("RecordResolution")]
    public List<RecordResolution> RecordResolutions { get; set; } = new List<RecordResolution>();
}

public class RecordResolution
{
    public int? RecordResolutionID { get; set; }
    public string? Name { get; set; }
}