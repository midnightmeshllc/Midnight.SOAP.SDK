using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;

/// <summary>
/// Represents the request body for creating a new purchase order in the Midnight SOAP API.
/// </summary>
[XmlRoot("PurchaseOrderNew")]
public class PurchaseOrderNewRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the purchase order new request.
    /// </summary>
    public required PurchaseOrderNewInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for creating a new purchase order in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderNewInputParameter
{
    /// <summary>Gets or sets the list of purchase orders.</summary>
    public required List<PurchaseOrderNew> PurchaseOrders { get; set; }
}

/// <summary>
/// Represents a new purchase order in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderNew : PurchaseOrder_UserDefinedFields
{
    /// <summary>Gets or sets the purchase order type.</summary>
    public required string PurchaseOrderType { get; set; } = "PO";
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
    /// <summary>Gets or sets the purchase order number.</summary>
    [XmlElement(IsNullable = true)]
    public string? PurchaseOrderNumber { get; set; }
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
}