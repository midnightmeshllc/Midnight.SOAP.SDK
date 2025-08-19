using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailUpdate")]
public class OrderVersionDetailUpdateRequestBody
{
    public required OrderVersionDetailUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailUpdateInputParameter : UserDefinedFields
{
    public required int OrderVersionDetailID { get; set; }
    public string? ServiceName { get; set; } = null;
    public decimal? Quantity { get; set; } = null;
    public decimal? UnitPrice { get; set; } = null;
    public decimal? RunRate { get; set; } = null;
    public decimal? SetupTime { get; set; } = null;
    public int? QtyDone { get; set; } = null;
    public bool? Complete { get; set; } = null;
    public string? ServiceHyperlink { get; set; } = null;
    public string? FileLocation { get; set; } = null;
    public string? Comment { get; set; } = null;
}