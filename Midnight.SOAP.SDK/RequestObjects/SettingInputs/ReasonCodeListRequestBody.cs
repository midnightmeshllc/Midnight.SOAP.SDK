using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing reason codes in the Midnight SOAP API.
/// </summary>
[XmlRoot("ReasonCodeList")]
public class ReasonCodeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the reason code list request.
    /// </summary>
    public required ReasonCodeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing reason codes in the Midnight SOAP API.
/// </summary>
public class ReasonCodeListInputParameter
{
    /// <summary>Gets or sets the reason code ID.</summary>
    public int? ReasonCodeID { get; set; } = null;
    /// <summary>Gets or sets the reason code.</summary>
    public string? ReasonCode { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the reason code is active.</summary>
    public bool Active { get; set; } = true;
}