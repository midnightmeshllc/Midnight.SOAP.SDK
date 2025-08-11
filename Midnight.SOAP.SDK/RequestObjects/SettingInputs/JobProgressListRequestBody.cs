
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("JobProgressList")]
public class JobProgressListRequestBody
{
    public required JobProgressListInputParameter InputParameter { get; set; }
}

public class JobProgressListInputParameter
{
    public string? JobProgressCode { get; set; }
    public string? JobProgressName { get; set; }
    public int? JobProgressSort { get; set; }
    public bool Active { get; set; } = true;
}