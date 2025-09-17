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
    public int? LocationID { get; set; } = null;
    /// <summary>Gets or sets the tracking number.</summary>
    public required string TrackingNo { get; set; } = string.Empty;
    /// <summary>Gets or sets the shipped date.</summary>
    public required string ShippedDate { get; set; } = string.Empty;
    /// <summary>Gets or sets the weight.</summary>
    public decimal? Weight { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the cost.</summary>
    public decimal? Cost { get; set; } = decimal.Zero;
    /// <summary>Gets or sets the service type.</summary>
    public string? ServiceType { get; set; } = null;
    /// <summary>Gets or sets the carrier.</summary>
    public string? Carrier { get; set; } = null;
}
