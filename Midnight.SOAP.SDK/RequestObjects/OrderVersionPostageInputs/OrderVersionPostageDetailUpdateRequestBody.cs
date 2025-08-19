
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

[XmlRoot("OrderVersionPostageDetailUpdate")]
public class OrderVersionPostageDetailUpdateRequestBody
{
    public required OrderVersionPostageDetailUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageDetailUpdateInputParameter
{
    public required int OrederVersionPostageDetailID { get; set; }
    public string? RateCode { get; set; } = null;
    public int? Quantity { get; set; } = null;
    public decimal? Rate { get; set; } = null;
    public decimal? DetailTotalWeight { get; set; } = null;
    public decimal? DetailTotalPostage { get; set; } = null;
    public string? WtType { get; set; } = null;
    public bool? Precanceled { get; set; } = null;
}