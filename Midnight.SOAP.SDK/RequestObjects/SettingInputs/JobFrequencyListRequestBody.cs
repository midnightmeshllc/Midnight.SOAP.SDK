
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("JobFrequencyList")]
public class JobFrequencyListRequestBody
{
    public required JobFrequencyListInputParameter InputParameter { get; set; }
}

public class JobFrequencyListInputParameter
{
    public int? JobFrequencyID { get; set; }
    public string? JobFrequencyDescription { get; set; }
    public bool Active { get; set; } = true;
}