
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("MailCategoryList")]
public class MailCategoryListRequestBody
{
    public required MailCategoryListInputParameter InputParameter { get; set; }
}

public class MailCategoryListInputParameter
{
    public int? MailCategoryID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}