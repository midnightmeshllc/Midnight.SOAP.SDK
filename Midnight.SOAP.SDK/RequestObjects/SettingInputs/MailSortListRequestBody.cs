
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("MailSortList")]
public class MailSortListRequestBody
{
    public required MailSortListInputParameter InputParameter { get; set; }
}

public class MailSortListInputParameter
{
    public int? MailSortID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}