
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class MailCategoryListResult : CommonResult
{
    [XmlArray("MailCategories")]
    [XmlArrayItem("MailCategory")]
    public List<MailCategory> MailCategories { get; set; } = new List<MailCategory>();
}

public class MailCategory
{
    public int? MailCategoryID { get; set; }
    public string? Name { get; set; }
}