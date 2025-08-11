
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("ReasonCodeList")]
public class ReasonCodeListRequestBody
{
    public required ReasonCodeListInputParameter InputParameter { get; set; }
}

public class ReasonCodeListInputParameter
{
    public int? ReasonCodeID { get; set; }
    public string? ReasonCode { get; set; }
    public bool Active { get; set; } = true;
}