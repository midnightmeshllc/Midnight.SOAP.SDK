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
    [XmlElement(IsNullable = true)]
    public string? PurchaseOrderType { get; set; }
    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorID { get; set; }
    /// <summary>Gets or sets the vendor contact ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? VendorContactID { get; set; }
    /// <summary>Gets or sets the vendor contact name.</summary>
    [XmlElement(IsNullable = true)]
    public string? VendorContactName { get; set; }
    /// <summary>Gets or sets the employee ID who ordered.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderedByEmployeeID { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the company ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CompanyID { get; set; }
    /// <summary>Gets or sets the invoice number.</summary>
    [XmlElement(IsNullable = true)]
    public string? InvoiceNumber { get; set; }
    /// <summary>Gets or sets the phone number.</summary>
    [XmlElement(IsNullable = true)]
    public int? Phone { get; set; }
    /// <summary>Gets or sets the fax number.</summary>
    [XmlElement(IsNullable = true)]
    public int? Fax { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? EmailAddress { get; set; }
    /// <summary>Gets or sets the terms code.</summary>
    [XmlElement(IsNullable = true)]
    public string? TermsCode { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the enter date.</summary>
    [XmlElement(IsNullable = true)]
    public string? EnterDate { get; set; }
    /// <summary>Gets or sets the invoice date.</summary>
    [XmlElement(IsNullable = true)]
    public string? InvoiceDate { get; set; }
    /// <summary>Gets or sets the ship date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipDate { get; set; }
    /// <summary>Gets or sets the close date.</summary>
    [XmlElement(IsNullable = true)]
    public string? CloseDate { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    [XmlElement(IsNullable = true)]
    public string? Comment { get; set; }
    /// <summary>Gets or sets the ship to company.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToCompany { get; set; }
    /// <summary>Gets or sets the ship to attention line.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAttnLine { get; set; }
    /// <summary>Gets or sets the ship to address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAddressLine1 { get; set; }
    /// <summary>Gets or sets the ship to address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAddressLine2 { get; set; }
    /// <summary>Gets or sets the ship to address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAddressLine3 { get; set; }
    /// <summary>Gets or sets the ship to city.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToCity { get; set; }
    /// <summary>Gets or sets the ship to state code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToStateCode { get; set; }
    /// <summary>Gets or sets the ship to zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToZipCode { get; set; }
    /// <summary>Gets or sets the ship to country code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToCountryCode { get; set; }
    /// <summary>Gets or sets the ship to delivery method ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ShipToDeliveryMethodID { get; set; }
    /// <summary>Gets or sets the bill to company.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToCompany { get; set; }
    /// <summary>Gets or sets the bill to attention line.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAttnLine { get; set; }
    /// <summary>Gets or sets the bill to address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAddressLine1 { get; set; }
    /// <summary>Gets or sets the bill to address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAddressLine2 { get; set; }
    /// <summary>Gets or sets the bill to address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAddressLine3 { get; set; }
    /// <summary>Gets or sets the bill to city.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToCity { get; set; }
    /// <summary>Gets or sets the bill to state code.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToStateCode { get; set; }
    /// <summary>Gets or sets the bill to zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToZipCode { get; set; }
    /// <summary>Gets or sets the bill to country code.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToCountryCode { get; set; }
    /// <summary>Gets or sets the actual invoice amount.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? ActualInvoiceAmount { get; set; }
    /// <summary>Gets or sets the expected date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ExpectedDate { get; set; }
    /// <summary>Gets or sets the list of purchase order items.</summary>
    public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();
}

/// <summary>
/// Represents a purchase order item in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderItem : PurchaseOrderItem_UserDefinedFieldsFirst15
{
    /// <summary>Gets or sets the purchase order item ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? PurchaseOrderItemID { get; set; }
    /// <summary>Gets or sets the item ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ItemID { get; set; }
    /// <summary>Gets or sets the item description.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
    /// <summary>Gets or sets the item quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? ItemQuantity { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? UnitPrice { get; set; }
    /// <summary>Gets or sets the markup percentage.</summary>
    [XmlElement(IsNullable = true)]
    public decimal? MarkupPercentage { get; set; }
    /// <summary>Gets or sets the item order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ItemOrderID { get; set; }
    /// <summary>Gets or sets the material in date.</summary>
    [XmlElement(IsNullable = true)]
    public string? MaterialInDate { get; set; }
    /// <summary>Gets or sets the GLID.</summary>
    [XmlElement(IsNullable = true)]
    public string? GLID { get; set; }
    /// <summary>Gets or sets the item code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the quantity received.</summary>
    [XmlElement(IsNullable = true)]
    public int? QuantityReceived { get; set; }
    /// <summary>Gets or sets the remove flag.</summary>
    [XmlElement(IsNullable = true)]
    public string? Remove { get; set; }
    /// <summary>Gets or sets the expected date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ExpectedDate { get; set; }
    /// <summary>Gets or sets the item estimate ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ItemEstimateID { get; set; }
}