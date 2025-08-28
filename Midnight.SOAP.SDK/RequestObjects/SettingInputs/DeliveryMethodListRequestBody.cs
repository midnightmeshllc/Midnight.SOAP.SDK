using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing delivery methods in the Midnight SOAP API.
/// </summary>
[XmlRoot("DeliveryMethodList")]
public class DeliveryMethodListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the delivery method list request.
    /// </summary>
    public required DeliveryMethodListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing delivery methods in the Midnight SOAP API.
/// </summary>
public class DeliveryMethodListInputParameter
{
    /// <summary>Gets or sets the delivery method ID.</summary>
    public int? DeliveryMethodID { get; set; }
    /// <summary>Gets or sets the delivery method name.</summary>
    public string? DeliveryMethodName { get; set; } = string.Empty;
    /// <summary>Gets or sets a value indicating whether the delivery method is active.</summary>
    public bool Active { get; set; } = true;
}