
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("ResidualInstructionList")]
public class ResidualInstructionListRequestBody
{
    public required ResidualInstructionListInputParameter InputParameter { get; set; }
}

public class ResidualInstructionListInputParameter
{
    public int? ResidualInstructionID { get; set; }
    public string? ResidualInstructionName { get; set; }
    public bool Active { get; set; } = true;
}