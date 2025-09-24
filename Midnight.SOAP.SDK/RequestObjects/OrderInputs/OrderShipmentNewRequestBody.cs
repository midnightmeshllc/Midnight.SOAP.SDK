using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

/// <summary>
/// Represents the request body for creating a new order shipment in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderShipmentNew")]
public class OrderShipmentNewRequestBody
{
    /// <summary>Gets or sets the order ID.</summary>
    public required int OrderID { get; set; }
    /// <summary>Gets or sets the version ID.</summary>
    public required int VersionID { get; set; }
    /// <summary>Gets or sets the location ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? LocationID { get; set; }
    /// <summary>Gets or sets the tracking number.</summary>
    public required string TrackingNo { get; set; } = string.Empty;
    /// <summary>Gets or sets the shipped date.</summary>
    public required string ShippedDate { get; set; } = string.Empty;
    /// <summary>Gets or sets the weight.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Weight { get; set; }
    /// <summary>Gets or sets the cost.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? Cost { get; set; }
    /// <summary>Gets or sets the service type.</summary>
    [XmlElement(IsNullable = true)]
    public string? ServiceType { get; set; }
    /// <summary>Gets or sets the carrier.</summary>
    [XmlElement(IsNullable = true)]
    public string? Carrier { get; set; }
}
