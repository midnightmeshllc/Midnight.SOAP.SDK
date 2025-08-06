
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("DocumentTypeList")]
public class DocumentTypeListRequestBody
{
    public required DocumentTypeListInputParameter InputParameter { get; set; }
}

public class DocumentTypeListInputParameter
{
    public int? DocumentTypeID { get; set; }
    public string? Name { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
}