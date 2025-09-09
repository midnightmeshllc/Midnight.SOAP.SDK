using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a delivery method list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class DeliveryMethodListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of delivery methods returned by the request.
    /// </summary>
    [XmlArray("DeliveryMethods")]
    [XmlArrayItem("DeliveryMethod")]
    public List<DeliveryMethod> DeliveryMethods { get; set; } = new List<DeliveryMethod>();
}

/// <summary>
/// Represents a delivery method in the Midnight SOAP API.
/// </summary>
public class DeliveryMethod
{
    /// <summary>Gets or sets the delivery method ID.</summary>
    public int DeliveryMethodID { get; set; }
    /// <summary>Gets or sets the name of the delivery method.</summary>
    public string? DeliveryMethodName { get; set; } = string.Empty;
}