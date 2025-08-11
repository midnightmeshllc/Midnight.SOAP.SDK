
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class PostageStatusListResult : CommonResult
{
    [XmlArray("PostageStatuses")]
    [XmlArrayItem("PostageStatus")]
    public List<PostageStatus> PostageStatuses { get; set; } = new List<PostageStatus>();
}

public class PostageStatus
{
    public int? PostageStatusID { get; set; }
    public string? Name { get; set; }
}