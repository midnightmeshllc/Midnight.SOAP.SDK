using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

[XmlRoot("OrderShipmentNew")]
public class OrderShipmentNewRequestBody
{
    public required int OrderID { get; set; }
    public required int VersionID { get; set; }
    public int? LocationID { get; set; }
    public required string TrackingNo { get; set; }
    public required DateOnly ShippedDate { get; set; }
    public decimal? Weight { get; set; } = decimal.Zero;
    public decimal? Cost { get; set; } = decimal.Zero;
    public string? ServiceType { get; set; }
    public string? Carrier { get; set; }
}
