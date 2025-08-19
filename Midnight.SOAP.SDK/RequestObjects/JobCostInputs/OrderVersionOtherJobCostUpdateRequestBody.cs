
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

[XmlRoot("OrderVersionOtherJobCostUpdate")]
public class OrderVersionOtherJobCostUpdateRequestBody
{
    public required int OrderVersionOtherJobCostID { get; set; }
    public required string Date { get; set; }
    public string? Type { get; set; }
    public string? Source { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public string? Description { get; set; }
}
