using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

/// <summary>
/// Represents the request body for updating an order in the Midnight SOAP API.
/// </summary>
[XmlRoot("OrderUpdate")]
public class OrderUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the order update.
    /// </summary>
    public required OrderUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameters for updating an order.
/// </summary>
public class OrderUpdateInputParameter : UserDefinedFields
{
    /// <summary>Gets or sets the order ID.</summary>
    public required int OrderID { get; set; }
    /// <summary>Gets or sets the customer ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CustomerID { get; set; }
    /// <summary>Gets or sets the contact ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ContactID { get; set; }
    /// <summary>Gets or sets the sales representative ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? SalesRepID { get; set; }
    /// <summary>Gets or sets the CSR ID.</summary>
    [XmlElement(IsNullable = true)]
    public string? CSRID { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the purchase order number.</summary>
    [XmlElement(IsNullable = true)]
    public string? PONumber { get; set; }
    /// <summary>Gets or sets the terms.</summary>
    [XmlElement(IsNullable = true)]
    public string? Terms { get; set; }
    /// <summary>Gets or sets a value indicating whether the order is taxable.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Taxable { get; set; }
    /// <summary>Gets or sets the order status ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderStatusID { get; set; }
    /// <summary>Gets or sets the order date.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderDate { get; set; }
    /// <summary>Gets or sets the data in date.</summary>
    [XmlElement(IsNullable = true)]
    public string? DataInDate { get; set; }
    /// <summary>Gets or sets a value indicating whether data in is set.</summary>
    [XmlElement(IsNullable = true)]
    public bool? DataInYN { get; set; }
    /// <summary>Gets or sets the material in date.</summary>
    [XmlElement(IsNullable = true)]
    public string? MaterialInDate { get; set; }
    /// <summary>Gets or sets a value indicating whether material in is set.</summary>
    [XmlElement(IsNullable = true)]
    public bool? MaterialInYN { get; set; }
    /// <summary>Gets or sets the artwork in date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ArtworkInDate { get; set; }
    /// <summary>Gets or sets a value indicating whether artwork in is set.</summary>
    [XmlElement(IsNullable = true)]
    public bool? ArtworkInYN { get; set; }
    /// <summary>Gets or sets the due date.</summary>
    [XmlElement(IsNullable = true)]
    public string? DueDate { get; set; }
    /// <summary>Gets or sets a value indicating whether due date is set.</summary>
    [XmlElement(IsNullable = true)]
    public bool? DueDateYN { get; set; }
    /// <summary>Gets or sets the time due.</summary>
    [XmlElement(IsNullable = true)]
    public string? TimeDue { get; set; }
    /// <summary>Gets or sets the ship date.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipDate { get; set; }
    /// <summary>Gets or sets the close date.</summary>
    [XmlElement(IsNullable = true)]
    public string? CloseDate { get; set; }
    /// <summary>Gets or sets the expected quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? ExpectedQty { get; set; }
    /// <summary>Gets or sets the residual instruction ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ResidualInstructionID { get; set; }
    /// <summary>Gets or sets the residual ship to information.</summary>
    [XmlElement(IsNullable = true)]
    public string? ResidualShipTo { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    [XmlElement(IsNullable = true)]
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the job progress code.</summary>
    [XmlElement(IsNullable = true)]
    public string? JobProgressCode { get; set; }
    /// <summary>Gets or sets the job priority ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? JobPriorityID { get; set; }
    /// <summary>Gets or sets the job frequency ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? JobFrequencyID { get; set; }
    /// <summary>Gets or sets the job type ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? JobTypeID { get; set; }
    /// <summary>Gets or sets the invoice comments.</summary>
    [XmlElement(IsNullable = true)]
    public string? InvoiceComments { get; set; }
    /// <summary>Gets or sets the shipping address.</summary>
    [XmlElement(IsNullable = true)]
    public OrderUpdateShipToAddress? ShippingAddress { get; set; }
    /// <summary>Gets or sets the billing address.</summary>
    [XmlElement(IsNullable = true)]
    public OrderUpdateBillToAddress? BillingAddress { get; set; }
    /// <summary>Gets or sets the shipping comments.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShippingComments { get; set; }
}

/// <summary>
/// Represents the billing address for an order update.
/// </summary>
public class OrderUpdateBillToAddress
{
    /// <summary>Gets or sets the bill-to contact ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? BillToContactID { get; set; }
    /// <summary>Gets or sets the bill-to name.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToName { get; set; }
    /// <summary>Gets or sets the bill-to address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAddressLine1 { get; set; }
    /// <summary>Gets or sets the bill-to address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAddressLine2 { get; set; }
    /// <summary>Gets or sets the bill-to address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToAddressLine3 { get; set; }
    /// <summary>Gets or sets the bill-to city.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToCity { get; set; }
    /// <summary>Gets or sets the bill-to state.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToState { get; set; }
    /// <summary>Gets or sets the bill-to zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToZip { get; set; }
    /// <summary>Gets or sets the bill-to country.</summary>
    [XmlElement(IsNullable = true)]
    public string? BillToCountry { get; set; }
}

/// <summary>
/// Represents the shipping address for an order update.
/// </summary>
public class OrderUpdateShipToAddress
{
    /// <summary>Gets or sets the ship-to contact ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ShipToContactID { get; set; }
    /// <summary>Gets or sets the ship-to name.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToName { get; set; }
    /// <summary>Gets or sets the ship-to address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAddressLine1 { get; set; }
    /// <summary>Gets or sets the ship-to address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAddressLine2 { get; set; }
    /// <summary>Gets or sets the ship-to address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToAddressLine3 { get; set; }
    /// <summary>Gets or sets the ship-to city.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToCity { get; set; }
    /// <summary>Gets or sets the ship-to state.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToState { get; set; }
    /// <summary>Gets or sets the ship-to zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToZip { get; set; }
    /// <summary>Gets or sets the ship-to country.</summary>
    [XmlElement(IsNullable = true)]
    public string? ShipToCountry { get; set; }
    /// <summary>Gets or sets the ship-to method ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ShipToMethodID { get; set; }
}