using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing customer types in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerTypeList")]
public class CustomerTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer type list request.
    /// </summary>
    public required CustomerTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing customer types in the Midnight SOAP API.
/// </summary>
public class CustomerTypeListInputParameter
{
    /// <summary>Gets or sets the customer type ID.</summary>
    public int? CustomerTypeID { get; set; }
    /// <summary>Gets or sets the name of the customer type.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets a value indicating whether the customer type is active.</summary>
    public bool? Active { get; set; } = true;
}