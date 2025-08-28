using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;

/// <summary>
/// Represents the result of creating a new order shipment in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderShipmentNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the new order shipment.
    /// </summary>
    [XmlElement("Id")]
    public int Id { get; set; }
}
