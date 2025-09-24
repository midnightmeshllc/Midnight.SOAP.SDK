using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing record resolutions in the Midnight SOAP API.
/// </summary>
[XmlRoot("RecordResolutionList")]
public class RecordResolutionListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the record resolution list request.
    /// </summary>
    public required RecordResolutionListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing record resolutions in the Midnight SOAP API.
/// </summary>
public class RecordResolutionListInputParameter
{
    /// <summary>Gets or sets the record resolution ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? RecordResolutionID { get; set; }
    /// <summary>Gets or sets the name of the record resolution.</summary>
    [XmlElement(IsNullable = true)]
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the record resolution is active.</summary>
    public bool Active { get; set; } = true;
}