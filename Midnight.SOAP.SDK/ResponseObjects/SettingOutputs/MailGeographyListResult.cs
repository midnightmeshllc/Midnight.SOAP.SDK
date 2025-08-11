
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class MailGeographyListResult : CommonResult
{
    [XmlArray("MailGeographies")]
    [XmlArrayItem("MailGeography")]
    public List<MailGeography> MailGeographies { get; set; } = new List<MailGeography>();
}

public class MailGeography
{
    public int? MailGeographyID { get; set; }
    public string? Name { get; set; }
}