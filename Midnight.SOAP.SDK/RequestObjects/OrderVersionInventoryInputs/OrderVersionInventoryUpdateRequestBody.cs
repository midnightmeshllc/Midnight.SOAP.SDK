using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

[XmlRoot("OrderVersionInventoryUpdate")]
public class OrderVersionInventoryUpdateRequestBody
{
    [Required]
    public required OrderVersionInventoryUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionInventoryUpdateInputParameter
{
    [Required]
    public int OrderInventoryID { get; set; }
    public string? Description { get; set; }
    public int? QuantityNeeded { get; set; }
    public int? Priority { get; set; }
    public string? Notes { get; set; }
}