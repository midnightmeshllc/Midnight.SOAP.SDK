
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("MailClassList")]
public class MailClassListRequestBody
{
    public required MailClassListInputParameter InputParameter { get; set; }
}

public class MailClassListInputParameter
{
    public int? MailClassID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}