
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class MailSortListResult : CommonResult
{
    [XmlArray("MailSorts")]
    [XmlArrayItem("MailSort")]
    public List<MailSort> MailSorts { get; set; } = new List<MailSort>();
}

public class MailSort
{
    public int? MailSortID { get; set; }
    public string? Name { get; set; }
}