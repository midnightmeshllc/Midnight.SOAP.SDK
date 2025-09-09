using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a residual instruction list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ResidualInstructionListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of residual instructions returned by the request.
    /// </summary>
    [XmlArray("ResidualInstructions")]
    [XmlArrayItem("ResidualInstruction")]
    public List<ResidualInstruction> ResidualInstructions { get; set; } = new List<ResidualInstruction>();
}

/// <summary>
/// Represents a residual instruction in the Midnight SOAP API.
/// </summary>
public class ResidualInstruction
{
    /// <summary>Gets or sets the residual instruction ID.</summary>
    public int? ResidualInstructionID { get; set; }
    /// <summary>Gets or sets the name of the residual instruction.</summary>
    public string? ResidualInstructionName { get; set; }
}