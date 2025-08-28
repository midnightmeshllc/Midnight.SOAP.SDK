using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;

/// <summary>
/// Represents the result of a purchase order list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PurchaseOrderListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of purchase orders returned by the request.
    /// </summary>
    [XmlArray("PurchaseOrders")]
    [XmlArrayItem("PurchaseOrder")]
    public List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();
}

/// <summary>
/// Represents a purchase order in the Midnight SOAP API.
/// </summary>
public class PurchaseOrder : PurchaseOrder_UserDefinedFields
{
    /// <summary>Gets or sets the purchase order ID.</summary>
    public int? PurchaseOrderID { get; set; }
    /// <summary>Gets or sets the purchase order type.</summary>
    public string? PurchaseOrderType { get; set; }
    /// <summary>Gets or sets the vendor ID.</summary>
    public int? VendorID { get; set; }
    /// <summary>Gets or sets the vendor contact ID.</summary>
    public int? VendorContactID { get; set; }
    /// <summary>Gets or sets the vendor contact name.</summary>
    public string? VendorContactName { get; set; }
    /// <summary>Gets or sets the employee ID who ordered.</summary>
    public int? OrderedByEmployeeID { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; }
    /// <summary>Gets or sets the invoice number.</summary>
    public string? InvoiceNumber { get; set; }
    /// <summary>Gets or sets the phone number.</summary>
    public int? Phone { get; set; }
    /// <summary>Gets or sets the fax number.</summary>
    public int? Fax { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    public string? EmailAddress { get; set; }
    /// <summary>Gets or sets the terms code.</summary>
    public string? TermsCode { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; }
    /// <summary>Gets or sets the invoice date.</summary>
    public string? InvoiceDate { get; set; }
    /// <summary>Gets or sets the ship date.</summary>
    public string? ShipDate { get; set; }
    /// <summary>Gets or sets the close date.</summary>
    public string? CloseDate { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    /// <summary>Gets or sets the ship-to company.</summary>
    public string? ShipToCompany { get; set; }
    /// <summary>Gets or sets the ship-to attention line.</summary>
    public string? ShipToAttnLine { get; set; }
    /// <summary>Gets or sets the ship-to address line 1.</summary>
    public string? ShipToAddressLine1 { get; set; }
    /// <summary>Gets or sets the ship-to address line 2.</summary>
    public string? ShipToAddressLine2 { get; set; }
    /// <summary>Gets or sets the ship-to address line 3.</summary>
    public string? ShipToAddressLine3 { get; set; }
    /// <summary>Gets or sets the ship-to city.</summary>
    public string? ShipToCity { get; set; }
    /// <summary>Gets or sets the ship-to state code.</summary>
    public string? ShipToStateCode { get; set; }
    /// <summary>Gets or sets the ship-to zip code.</summary>
    public string? ShipToZipCode { get; set; }
    /// <summary>Gets or sets the ship-to country code.</summary>
    public string? ShipToCountryCode { get; set; }
    /// <summary>Gets or sets the ship-to delivery method ID.</summary>
    public int? ShipToDeliveryMethodID { get; set; }
    /// <summary>Gets or sets the bill-to company.</summary>
    public string? BillToCompany { get; set; }
    /// <summary>Gets or sets the bill-to attention line.</summary>
    public string? BillToAttnLine { get; set; }
    /// <summary>Gets or sets the bill-to address line 1.</summary>
    public string? BillToAddressLine1 { get; set; }
    /// <summary>Gets or sets the bill-to address line 2.</summary>
    public string? BillToAddressLine2 { get; set; }
    /// <summary>Gets or sets the bill-to address line 3.</summary>
    public string? BillToAddressLine3 { get; set; }
    /// <summary>Gets or sets the bill-to city.</summary>
    public string? BillToCity { get; set; }
    /// <summary>Gets or sets the bill-to state code.</summary>
    public string? BillToStateCode { get; set; }
    /// <summary>Gets or sets the bill-to zip code.</summary>
    public string? BillToZipCode { get; set; }
    /// <summary>Gets or sets the bill-to country code.</summary>
    public string? BillToCountryCode { get; set; }
    /// <summary>Gets or sets the actual invoice amount.</summary>
    public decimal? ActualInvoiceAmount { get; set; }
    /// <summary>Gets or sets the expected date.</summary>
    public string? ExpectedDate { get; set; }

}