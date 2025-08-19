
using Midnight.SOAP.SDK.CommonObjects;
using MidnightAPI;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;

[XmlRoot("PurchaseOrderUpdate")]
public class PurchaseOrderUpdateRequestBody
{
    public required PurchaseOrderUpdateInputParameter InputParameter { get; set; }
}

public class PurchaseOrderUpdateInputParameter
{
    public required List<PurchaseOrderUpdateInput> PurchaseOrder { get; set; } = new List<PurchaseOrderUpdateInput>();
}

public class PurchaseOrderUpdateInput : PurchaseOrder_UserDefinedFields
{
    public required int PurchaseOrderID { get; set; }
    public string? PurchaseOrderType { get; set; } = null;
    public required int VendorID { get; set; }
    public int? VendorContactID { get; set; } = null;
    public string? VendorContactName { get; set; } = null;
    public int? OrderedByEmployeeID { get; set; } = null;
    public int? OrderID { get; set; } = null;
    public int? CompanyID { get; set; } = null;
    public string? InvoiceNumber { get; set; } = null;
    public int? Phone { get; set; } = null;
    public int? Fax { get; set; } = null;
    public string? EmailAddress { get; set; } = null;
    public string? TermsCode { get; set; } = null;
    public string? ProjectName { get; set; } = null;
    public string? EnterDate { get; set; } = null;
    public string? InvoiceDate { get; set; } = null;
    public string? ShipDate { get; set; } = null;
    public string? CloseDate { get; set; } = null;
    public string? Comment { get; set; } = null;
    public string? ShipToCompany { get; set; } = null;
    public string? ShipToAttnLine { get; set; } = null;
    public string? ShipToAddressLine1 { get; set; } = null;
    public string? ShipToAddressLine2 { get; set; } = null;
    public string? ShipToAddressLine3 { get; set; } = null;
    public string? ShipToCity { get; set; } = null;
    public string? ShipToStateCode { get; set; } = null;
    public string? ShipToZipCode { get; set; } = null;
    public string? ShipToCountryCode { get; set; } = null;
    public int? ShipToDeliveryMethodID { get; set; } = null;
    public string? BillToCompany { get; set; } = null;
    public string? BillToAttnLine { get; set; } = null;
    public string? BillToAddressLine1 { get; set; } = null;
    public string? BillToAddressLine2 { get; set; } = null;
    public string? BillToAddressLine3 { get; set; } = null;
    public string? BillToCity { get; set; } = null;
    public string? BillToStateCode { get; set; } = null;
    public string? BillToZipCode { get; set; } = null;
    public string? BillToCountryCode { get; set; } = null;
    public decimal? ActualInvoiceAmount { get; set; } = null;
    public string? ExpectedDate { get; set; } = null;
    public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();
}

public class PurchaseOrderItem : PurchaseOrderItem_UserDefinedFieldsFirst15
{
    public int? PurchaseOrderItemID { get; set; } = null;
    public int? ItemID { get; set; } = null;
    public string? Description { get; set; } = null;
    public int? ItemQuantity { get; set; } = null;
    public decimal? UnitPrice { get; set; } = null;
    public decimal? MarkupPercentage { get; set; } = null;
    public int? ItemOrderID { get; set; } = null;
    public string? MaterialInDate { get; set; } = null;
    public string? GLID { get; set; } = null;
    public string? ItemCode { get; set; } = null;
    public int? QuantityReceived { get; set; } = null;
    public string? Remove { get; set; } = null;
    public string? ExpectedDate { get; set; } = null;
    public int? ItemEstimateID { get; set; } = null;
}