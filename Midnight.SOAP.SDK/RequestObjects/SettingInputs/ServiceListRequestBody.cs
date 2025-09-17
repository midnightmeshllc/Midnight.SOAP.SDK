using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing services in the Midnight SOAP API.
/// </summary>
[XmlRoot("ServiceList")]
public class ServiceListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the service list request.
    /// </summary>
    public required ServiceListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing services in the Midnight SOAP API.
/// </summary>
public class ServiceListInputParameter
{
    /// <summary>Gets or sets the service ID.</summary>
    public int? ServiceID { get; set; } = null;
    /// <summary>Gets or sets the service type ID.</summary>
    public int? ServiceTypeID { get; set; } = null;
    /// <summary>Gets or sets the service type code.</summary>
    public string? ServiceTypeCode { get; set; } = null;
    /// <summary>Gets or sets the service type name.</summary>
    public string? ServiceTypeName { get; set; } = null;
    /// <summary>Gets or sets the service code.</summary>
    public string? ServiceCode { get; set; } = null;
    /// <summary>Gets or sets the service name.</summary>
    public string? ServiceName { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the service is active.</summary>
    public bool Active { get; set; } = true;
}