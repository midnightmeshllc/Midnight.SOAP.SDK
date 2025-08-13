
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class TermsListResult : CommonResult
{
    [XmlArray("TermsList")]
    [XmlArrayItem("Terms")]
    public List<Terms> TermsList { get; set; } = new List<Terms>();
}

public class Terms
{
    public string? TermsCode { get; set; }
    public string? TermsName { get; set; }
    public int? DaysTillDue { get; set; }
}