
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class PostOfficeListResult : CommonResult
{
    [XmlArray("PostOffices")]
    [XmlArrayItem("PostOffice")]
    public List<PostOffice> PostOffices { get; set; } = new List<PostOffice>();
}

public class PostOffice
{
    public int? PostOfficeID { get; set; }
    public string? Name { get; set; }
}