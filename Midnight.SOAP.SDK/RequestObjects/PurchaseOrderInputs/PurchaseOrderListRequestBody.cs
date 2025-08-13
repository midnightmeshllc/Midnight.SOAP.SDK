
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;

[XmlRoot("PurchaseOrderList")]
public class PurchaseOrderListRequestBody
{
    public required PurchaseOrderListInputParameter InputParameter { get; set; }
}

public class PurchaseOrderListInputParameter
{
    public string? PurchaseOrderType { get; set; }
    public int? PurchaseOrderID { get; set; }
    public int? VendorID { get; set; }
    public int? OrderID { get; set; }
    public int? CompanyID { get; set; }
}