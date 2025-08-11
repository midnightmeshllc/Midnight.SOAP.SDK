
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("PostOfficeList")]
public class PostOfficeListRequestBody
{
    public required PostOfficeListInputParameter InputParameter { get; set; }
}

public class PostOfficeListInputParameter
{
    public int? PostOfficeID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}