using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailUpdate")]
public class OrderVersionDetailUpdateRequestBody
{
    public required OrderVersionDetailUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailUpdateInputParameter
{
    [Required]
    public int OrderVersionDetailID { get; set; }
    public string? ServiceName { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitPrice { get; set; }
    public decimal? RunRate { get; set; }
    public decimal? SetupTime { get; set; }
    public int? QtyDone { get; set; }
    public bool? Complete { get; set; }
    public string? ServiceHyperlink { get; set; }
    public string? FileLocation { get; set; }
    public string? Comment { get; set; }
}