using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

[XmlRoot("OrderVersionDropUpdate")]
public class OrderVersionDropUpdateRequestBody
{
    public required OrderVersionDropUpdateInputParameter InputParameter { get; set; }
}

public class OrderVersionDropUpdateInputParameter
{
    public int OrderVersionDropID { get; set; }
    public string DropDate { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string DropName { get; set; } = string.Empty;
    public string TimeDue { get; set; } = string.Empty;
    public string ActualDrop { get; set; } = string.Empty;
    public bool DropDateComplete { get; set; }
    public decimal PostageValue { get; set; }
}