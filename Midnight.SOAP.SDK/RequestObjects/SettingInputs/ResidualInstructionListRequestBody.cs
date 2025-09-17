using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing residual instructions in the Midnight SOAP API.
/// </summary>
[XmlRoot("ResidualInstructionList")]
public class ResidualInstructionListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the residual instruction list request.
    /// </summary>
    public required ResidualInstructionListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing residual instructions in the Midnight SOAP API.
/// </summary>
public class ResidualInstructionListInputParameter
{
    /// <summary>Gets or sets the residual instruction ID.</summary>
    public int? ResidualInstructionID { get; set; } = null;
    /// <summary>Gets or sets the name of the residual instruction.</summary>
    public string? ResidualInstructionName { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the residual instruction is active.</summary>
    public bool Active { get; set; } = true;
}