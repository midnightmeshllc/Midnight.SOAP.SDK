
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class ResidualInstructionListResult : CommonResult
{
    [XmlArray("ResidualInstructions")]
    [XmlArrayItem("ResidualInstruction")]
    public List<ResidualInstruction> ResidualInstructions { get; set; } = new List<ResidualInstruction>();
}

public class ResidualInstruction
{
    public int? ResidualInstructionID { get; set; }
    public string? ResidualInstructionName { get; set; }
}