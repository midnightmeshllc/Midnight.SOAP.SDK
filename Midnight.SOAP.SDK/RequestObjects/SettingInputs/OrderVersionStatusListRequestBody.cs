using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing order version statuses in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderVersionStatusList")]
public class OrderVersionStatusListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order version status list request.
    /// </summary>
    public required OrderVersionStatusListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order version statuses in the Midnight SOAP API.
/// </summary>
public class OrderVersionStatusListInputParameter
{
    /// <summary>Gets or sets the order version status ID.</summary>
    public int? OrderVersionStatusID { get; set; } = null;
    /// <summary>Gets or sets the name of the order version status.</summary>
    public string? Name { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the order version status is active.</summary>
    public bool Active { get; set; } = true;
}