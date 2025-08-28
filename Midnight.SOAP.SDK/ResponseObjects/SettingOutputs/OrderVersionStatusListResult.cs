using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of an order version status list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionStatusListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of order version statuses returned by the request.
    /// </summary>
    [XmlArray("OrderVersionStatuses")]
    [XmlArrayItem("OrderVersionStatus")]
    public List<OrderVersionStatus>? OrderVersionStatuses { get; set; } = new List<OrderVersionStatus>();
}

/// <summary>
/// Represents an order version status in the Midnight SOAP API.
/// </summary>
public class OrderVersionStatus
{
    /// <summary>Gets or sets the order version status ID.</summary>
    public int OrderVersionStatusID { get; set; }
    /// <summary>Gets or sets the name of the order version status.</summary>
    public string Name { get; set; } = string.Empty;
}