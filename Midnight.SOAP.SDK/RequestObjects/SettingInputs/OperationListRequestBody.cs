
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("OperationListRequest")]
public class OperationListRequestBody
{
    public string? OperationCode { get; set; }
    public string? Description { get; set; }
    public bool Active { get; set; } = true;
}
