
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("ContactTypeList")]
public class ContactTypeListRequestBody
{
    public required ContactTypeListInputParameter InputParameter { get; set; }
}

public class ContactTypeListInputParameter
{
    public int? ContactTypeID { get; set; }
    public string? ContactTypeName { get; set; }
    public bool Active { get; set; } = true;
}