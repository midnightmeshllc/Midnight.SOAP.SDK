
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;

[XmlRoot("Result")]
public class PurchaseOrderListResult : CommonResult
{
    [XmlArray("PurchaseOrders")]
    [XmlArrayItem("PurchaseOrder")]
    public List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
}

public class PurchaseOrder : PurchaseOrder_UserDefinedFields
{
    public int? PurchaseOrderID { get; set; }
    public string? PurchaseOrderType { get; set; }
    public int? VendorID { get; set; }
    public int? VendorContactID { get; set; }
    public string? VendorContactName { get; set; }
    public int? OrderedByEmployeeID { get; set; }
    public int? OrderID { get; set; }
    public int? CompanyID { get; set; }
    public string? InvoiceNumber { get; set; }
    public int? Phone { get; set; }
    public int? Fax { get; set; }
    public string? EmailAddress { get; set; }
    public string? TermsCode { get; set; }
    public string? ProjectName { get; set; }
    public string? EnterDate { get; set; }
    public string? InvoiceDate { get; set; }
    public string? ShipDate { get; set; }
    public string? CloseDate { get; set; }
    public string? Comment { get; set; }
    public string? ShipToCompany { get; set; }
    public string? ShipToAttnLine { get; set; }
    public string? ShipToAddressLine1 { get; set; }
    public string? ShipToAddressLine2 { get; set; }
    public string? ShipToAddressLine3 { get; set; }
    public string? ShipToCity { get; set; }
    public string? ShipToStateCode { get; set; }
    public string? ShipToZipCode { get; set; }
    public string? ShipToCountryCode { get; set; }
    public int? ShipToDeliveryMethodID { get; set; }
    public string? BillToCompany { get; set; }
    public string? BillToAttnLine { get; set; }
    public string? BillToAddressLine1 { get; set; }
    public string? BillToAddressLine2 { get; set; }
    public string? BillToAddressLine3 { get; set; }
    public string? BillToCity { get; set; }
    public string? BillToStateCode { get; set; }
    public string? BillToZipCode { get; set; }
    public string? BillToCountryCode { get; set; }
    public decimal? ActualInvoiceAmount { get; set; }
    public string? ExpectedDate { get; set; }

}