using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;

/// <summary>
/// Represents the result of deleting an order version detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDetailDeleteResult : CommonResult
{
    /// <summary>
    /// Gets or sets the result message for the order version detail delete operation.
    /// </summary>
    public string? OrderVersionDetailDelete { get; set; }
}
