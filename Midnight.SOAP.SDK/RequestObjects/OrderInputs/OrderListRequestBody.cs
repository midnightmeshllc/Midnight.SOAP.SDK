using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

[XmlRoot("OrderList")]
public class OrderListRequestBody
{
    public required OrderListInputParameter InputParameter { get; set; } = new OrderListInputParameter();
}

public class OrderListInputParameter
{
    public string? OrderNumber { get; set; } = string.Empty;
    public string? CopyFromOrderNumber { get; set; } = string.Empty;
    public int? CustomerID { get; set; }
    public string? CustomerCode { get; set; } = string.Empty;
    public string? OrderDateFrom { get; set; } = string.Empty;
    public string? OrderDateTo { get; set; } = string.Empty;
    public string? OrderStatus { get; set; } = string.Empty;
    public string? OrderDueDateFrom { get; set; } = string.Empty;
    public string? OrderDueDateTo { get; set; } = string.Empty;
    public string? OrderCloseDateFrom { get; set; } = string.Empty;
    public string? OrderCloseDateTo { get; set; } = string.Empty;
    public string? Ordermodifieddate { get; set; } = string.Empty;
    public bool? OpenOrdersOnly { get; set; } = true;
}
