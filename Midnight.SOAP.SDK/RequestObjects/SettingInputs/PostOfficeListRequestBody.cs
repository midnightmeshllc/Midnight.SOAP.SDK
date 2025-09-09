using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing post offices in the Midnight SOAP API.
/// </summary>
[XmlRoot("PostOfficeList")]
public class PostOfficeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the post office list request.
    /// </summary>
    public required PostOfficeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing post offices in the Midnight SOAP API.
/// </summary>
public class PostOfficeListInputParameter
{
    /// <summary>Gets or sets the post office ID.</summary>
    public int? PostOfficeID { get; set; }
    /// <summary>Gets or sets the name of the post office.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the post office is active.</summary>
    public bool Active { get; set; } = true;
}