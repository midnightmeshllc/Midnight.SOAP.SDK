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
    [XmlElement(IsNullable = true)]
    public int? ServiceID { get; set; }
    /// <summary>Gets or sets the service type ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ServiceTypeID { get; set; }
    /// <summary>Gets or sets the service type code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceTypeCode { get; set; }
    /// <summary>Gets or sets the service type name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceTypeName { get; set; }
    /// <summary>Gets or sets the service code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceCode { get; set; }
    /// <summary>Gets or sets the service name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceName { get; set; }
    /// <summary>Gets or sets a value indicating whether the service is active.</summary>
    public bool Active { get; set; } = true;
}