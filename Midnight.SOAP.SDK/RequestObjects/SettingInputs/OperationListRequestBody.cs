using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing operations in the Midnight SOAP API.
/// </summary>
[XmlRoot("OperationListRequest")]
public class OperationListRequestBody
{
    /// <summary>Gets or sets the operation code.</summary>
    public string? OperationCode { get; set; }
    /// <summary>Gets or sets the description of the operation.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets a value indicating whether the operation is active.</summary>
    public bool Active { get; set; } = true;
}
