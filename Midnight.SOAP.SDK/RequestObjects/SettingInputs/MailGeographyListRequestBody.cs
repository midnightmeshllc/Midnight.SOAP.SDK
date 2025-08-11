
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("MailGeographyList")]
public class MailGeographyListRequestBody 
{
    public required MailGeographyListInputParameter InputParameter { get; set; }
}

public class MailGeographyListInputParameter
{
    public int? MailGeographyID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}