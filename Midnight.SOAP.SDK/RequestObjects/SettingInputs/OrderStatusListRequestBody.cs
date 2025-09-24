using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

/// <summary>
/// Represents the request body for listing order statuses in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderStatusList")]
public class OrderStatusListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order status list request.
    /// </summary>
    public required OrderStatusListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing order statuses in the Midnight SOAP API.
/// </summary>
public class OrderStatusListInputParameter
{
    /// <summary>Gets or sets the order status ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderStatusID { get; set; }
    /// <summary>Gets or sets the order status name.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderStatusName { get; set; }
    /// <summary>Gets or sets the order status type.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderStatusType { get; set; }
    /// <summary>Gets or sets a value indicating whether the order status is active.</summary>
    public bool Active { get; set; } = true;
}