
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class MailClassListResult : CommonResult
{
    [XmlArray("MailClasses")]
    [XmlArrayItem("MailClass")]
    public List<MailClass> MailClasses { get; set; } = new List<MailClass>();
}

public class MailClass
{
    public int? MailClassID { get; set; }
    public string? Name { get; set; }
}