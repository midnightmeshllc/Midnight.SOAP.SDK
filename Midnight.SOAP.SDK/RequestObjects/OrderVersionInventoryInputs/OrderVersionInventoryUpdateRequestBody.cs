using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

[XmlRoot("OrderVersionInventoryUpdate")]
public class OrderVersionInventoryUpdateRequestBody
{
    public required OrderVersionInventoryUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionInventoryUpdateInputParameter
{
    public required int OrderInventoryID { get; set; }
    public string? Description { get; set; } = null;
    public int? QuantityNeeded { get; set; } = null;
    public int? Priority { get; set; } = null;
    public string? Notes { get; set; } = null;
}