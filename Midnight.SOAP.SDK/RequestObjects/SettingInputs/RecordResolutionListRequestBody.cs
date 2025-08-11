
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("RecordResolutionList")]
public class RecordResolutionListRequestBody
{
    public required RecordResolutionListInputParameter InputParameter { get; set; }
}

public class RecordResolutionListInputParameter
{
    public int? RecordResolutionID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}