using Midnight.SOAP.SDK.CommonObjects;
using MidnightAPI;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;

/// <summary>
/// Represents the request body for updating a purchase order in the Midnight SOAP API.
/// </summary>
[XmlRoot("PurchaseOrderUpdate")]
public class PurchaseOrderUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the purchase order update request.
    /// </summary>
    public required PurchaseOrderUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating a purchase order in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderUpdateInputParameter
{
    /// <summary>Gets or sets the list of purchase orders to update.</summary>
    public required List<PurchaseOrderUpdateInput> PurchaseOrder { get; set; } = new List<PurchaseOrderUpdateInput>();
}

/// <summary>
/// Represents a purchase order update input in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderUpdateInput : PurchaseOrder_UserDefinedFields
{
    /// <summary>Gets or sets the purchase order ID.</summary>
    public required int PurchaseOrderID { get; set; }
    /// <summary>Gets or sets the purchase order type.</summary>
    public string? PurchaseOrderType { get; set; } = null;
    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorID { get; set; }
    /// <summary>Gets or sets the vendor contact ID.</summary>
    public int? VendorContactID { get; set; } = null;
    /// <summary>Gets or sets the vendor contact name.</summary>
    public string? VendorContactName { get; set; } = null;
    /// <summary>Gets or sets the employee ID who ordered.</summary>
    public int? OrderedByEmployeeID { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; } = null;
    /// <summary>Gets or sets the invoice number.</summary>
    public string? InvoiceNumber { get; set; } = null;
    /// <summary>Gets or sets the phone number.</summary>
    public int? Phone { get; set; } = null;
    /// <summary>Gets or sets the fax number.</summary>
    public int? Fax { get; set; } = null;
    /// <summary>Gets or sets the email address.</summary>
    public string? EmailAddress { get; set; } = null;
    /// <summary>Gets or sets the terms code.</summary>
    public string? TermsCode { get; set; } = null;
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; } = null;
    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; } = null;
    /// <summary>Gets or sets the invoice date.</summary>
    public string? InvoiceDate { get; set; } = null;
    /// <summary>Gets or sets the ship date.</summary>
    public string? ShipDate { get; set; } = null;
    /// <summary>Gets or sets the close date.</summary>
    public string? CloseDate { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
    /// <summary>Gets or sets the ship to company.</summary>
    public string? ShipToCompany { get; set; } = null;
    /// <summary>Gets or sets the ship to attention line.</summary>
    public string? ShipToAttnLine { get; set; } = null;
    /// <summary>Gets or sets the ship to address line 1.</summary>
    public string? ShipToAddressLine1 { get; set; } = null;
    /// <summary>Gets or sets the ship to address line 2.</summary>
    public string? ShipToAddressLine2 { get; set; } = null;
    /// <summary>Gets or sets the ship to address line 3.</summary>
    public string? ShipToAddressLine3 { get; set; } = null;
    /// <summary>Gets or sets the ship to city.</summary>
    public string? ShipToCity { get; set; } = null;
    /// <summary>Gets or sets the ship to state code.</summary>
    public string? ShipToStateCode { get; set; } = null;
    /// <summary>Gets or sets the ship to zip code.</summary>
    public string? ShipToZipCode { get; set; } = null;
    /// <summary>Gets or sets the ship to country code.</summary>
    public string? ShipToCountryCode { get; set; } = null;
    /// <summary>Gets or sets the ship to delivery method ID.</summary>
    public int? ShipToDeliveryMethodID { get; set; } = null;
    /// <summary>Gets or sets the bill to company.</summary>
    public string? BillToCompany { get; set; } = null;
    /// <summary>Gets or sets the bill to attention line.</summary>
    public string? BillToAttnLine { get; set; } = null;
    /// <summary>Gets or sets the bill to address line 1.</summary>
    public string? BillToAddressLine1 { get; set; } = null;
    /// <summary>Gets or sets the bill to address line 2.</summary>
    public string? BillToAddressLine2 { get; set; } = null;
    /// <summary>Gets or sets the bill to address line 3.</summary>
    public string? BillToAddressLine3 { get; set; } = null;
    /// <summary>Gets or sets the bill to city.</summary>
    public string? BillToCity { get; set; } = null;
    /// <summary>Gets or sets the bill to state code.</summary>
    public string? BillToStateCode { get; set; } = null;
    /// <summary>Gets or sets the bill to zip code.</summary>
    public string? BillToZipCode { get; set; } = null;
    /// <summary>Gets or sets the bill to country code.</summary>
    public string? BillToCountryCode { get; set; } = null;
    /// <summary>Gets or sets the actual invoice amount.</summary>
    public decimal? ActualInvoiceAmount { get; set; } = null;
    /// <summary>Gets or sets the expected date.</summary>
    public string? ExpectedDate { get; set; } = null;
    /// <summary>Gets or sets the list of purchase order items.</summary>
    public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();
}

/// <summary>
/// Represents a purchase order item in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderItem : PurchaseOrderItem_UserDefinedFieldsFirst15
{
    /// <summary>Gets or sets the purchase order item ID.</summary>
    public int? PurchaseOrderItemID { get; set; } = null;
    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; } = null;
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; } = null;
    /// <summary>Gets or sets the item quantity.</summary>
    public int? ItemQuantity { get; set; } = null;
    /// <summary>Gets or sets the unit price.</summary>
    public decimal? UnitPrice { get; set; } = null;
    /// <summary>Gets or sets the markup percentage.</summary>
    public decimal? MarkupPercentage { get; set; } = null;
    /// <summary>Gets or sets the item order ID.</summary>
    public int? ItemOrderID { get; set; } = null;
    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; } = null;
    /// <summary>Gets or sets the GLID.</summary>
    public string? GLID { get; set; } = null;
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; } = null;
    /// <summary>Gets or sets the quantity received.</summary>
    public int? QuantityReceived { get; set; } = null;
    /// <summary>Gets or sets the remove flag.</summary>
    public string? Remove { get; set; } = null;
    /// <summary>Gets or sets the expected date.</summary>
    public string? ExpectedDate { get; set; } = null;
    /// <summary>Gets or sets the item estimate ID.</summary>
    public int? ItemEstimateID { get; set; } = null;
}