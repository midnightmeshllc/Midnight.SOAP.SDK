
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class DocumentTypeListResult : CommonResult
{
    [XmlArray("DocumentTypes")]
    [XmlArrayItem("DocumentType")]
    public List<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();
}

public class DocumentType
{
    public int DocumentTypeID { get; set; }
    public string? Name { get; set; } = string.Empty;
}