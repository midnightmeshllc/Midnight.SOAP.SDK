
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

[XmlRoot("OrderVersionOtherJobCostInsert")]
public class OrderVersionOtherJobCostInsertRequestBody
{
    public required int OrderID { get; set; }
    public required int VersionID { get; set; }
    public required DateOnly Date { get; set; }
    public string? Type { get; set; }
    public string? Source { get; set; }
    public decimal? Quantity { get; set; } = decimal.Zero;
    public decimal? UnitPrice { get; set; } = decimal.Zero;
    public string? Description { get; set; }
}
