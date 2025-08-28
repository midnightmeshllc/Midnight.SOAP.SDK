using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing postage statuses in the Midnight SOAP API.
/// </summary>
[XmlRoot("PostageStatusList")]
public class PostageStatusListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the postage status list request.
    /// </summary>
    public required PostageStatusListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing postage statuses in the Midnight SOAP API.
/// </summary>
public class PostageStatusListInputParameter
{
    /// <summary>Gets or sets the postage status ID.</summary>
    public int? PostageStatusID { get; set; }
    /// <summary>Gets or sets the name of the postage status.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the postage status is active.</summary>
    public bool Active { get; set; } = true;
}