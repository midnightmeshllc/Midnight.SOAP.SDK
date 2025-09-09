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
    public int? CustomerID { get; set; } = null;
    /// <summary>Gets or sets the contact ID.</summary>
    public int? ContactID { get; set; } = null;
    /// <summary>Gets or sets the sales representative ID.</summary>
    public int? SalesRepID { get; set; } = null;
    /// <summary>Gets or sets the CSR ID.</summary>
    public string? CSRID { get; set; } = null;
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; } = null;
    /// <summary>Gets or sets the purchase order number.</summary>
    public string? PONumber { get; set; } = null;
    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the order is taxable.</summary>
    public bool? Taxable { get; set; } = null;
    /// <summary>Gets or sets the order status ID.</summary>
    public int? OrderStatusID { get; set; } = null;
    /// <summary>Gets or sets the order date.</summary>
    public string? OrderDate { get; set; } = null;
    /// <summary>Gets or sets the data in date.</summary>
    public string? DataInDate { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether data in is set.</summary>
    public bool? DataInYN { get; set; } = null;
    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether material in is set.</summary>
    public bool? MaterialInYN { get; set; } = true;
    /// <summary>Gets or sets the artwork in date.</summary>
    public string? ArtworkInDate { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether artwork in is set.</summary>
    public bool? ArtworkInYN { get; set; } = null;
    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether due date is set.</summary>
    public bool? DueDateYN { get; set; } = null;
    /// <summary>Gets or sets the time due.</summary>
    public string? TimeDue { get; set; } = null;
    /// <summary>Gets or sets the ship date.</summary>
    public string? ShipDate { get; set; } = null;
    /// <summary>Gets or sets the close date.</summary>
    public string? CloseDate { get; set; } = null;
    /// <summary>Gets or sets the expected quantity.</summary>
    public int? ExpectedQty { get; set; } = null;
    /// <summary>Gets or sets the residual instruction ID.</summary>
    public int? ResidualInstructionID { get; set; } = null;
    /// <summary>Gets or sets the residual ship to information.</summary>
    public string? ResidualShipTo { get; set; } = null;
    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; } = null;
    /// <summary>Gets or sets the job progress code.</summary>
    public string? JobProgressCode { get; set; } = null;
    /// <summary>Gets or sets the job priority ID.</summary>
    public int? JobPriorityID { get; set; } = null;
    /// <summary>Gets or sets the job frequency ID.</summary>
    public int? JobFrequencyID { get; set; } = null;
    /// <summary>Gets or sets the job type ID.</summary>
    public int? JobTypeID { get; set; } = null;
    /// <summary>Gets or sets the invoice comments.</summary>
    public string? InvoiceComments { get; set; } = null;
    /// <summary>Gets or sets the shipping address.</summary>
    public OrderUpdateShipToAddress? ShippingAddress { get; set; } = null;
    /// <summary>Gets or sets the billing address.</summary>
    public OrderUpdateBillToAddress? BillingAddress { get; set; } = null;
    /// <summary>Gets or sets the shipping comments.</summary>
    public string? ShippingComments { get; set; } = null;
}

/// <summary>
/// Represents the billing address for an order update.
/// </summary>
public class OrderUpdateBillToAddress
{
    /// <summary>Gets or sets the bill-to contact ID.</summary>
    public int? BillToContactID { get; set; } = null;
    /// <summary>Gets or sets the bill-to name.</summary>
    public string? BillToName { get; set; } = null;
    /// <summary>Gets or sets the bill-to address line 1.</summary>
    public string? BillToAddressLine1 { get; set; } = null;
    /// <summary>Gets or sets the bill-to address line 2.</summary>
    public string? BillToAddressLine2 { get; set; } = null;
    /// <summary>Gets or sets the bill-to address line 3.</summary>
    public string? BillToAddressLine3 { get; set; } = null;
    /// <summary>Gets or sets the bill-to city.</summary>
    public string? BillToCity { get; set; } = null;
    /// <summary>Gets or sets the bill-to state.</summary>
    public string? BillToState { get; set; } = null;
    /// <summary>Gets or sets the bill-to zip code.</summary>
    public string? BillToZip { get; set; } = null;
    /// <summary>Gets or sets the bill-to country.</summary>
    public string? BillToCountry { get; set; } = null;
}

/// <summary>
/// Represents the shipping address for an order update.
/// </summary>
public class OrderUpdateShipToAddress
{
    /// <summary>Gets or sets the ship-to contact ID.</summary>
    public int? ShipToContactID { get; set; } = null;
    /// <summary>Gets or sets the ship-to name.</summary>
    public string? ShipToName { get; set; } = null;
    /// <summary>Gets or sets the ship-to address line 1.</summary>
    public string? ShipToAddressLine1 { get; set; } = null;
    /// <summary>Gets or sets the ship-to address line 2.</summary>
    public string? ShipToAddressLine2 { get; set; } = null;
    /// <summary>Gets or sets the ship-to address line 3.</summary>
    public string? ShipToAddressLine3 { get; set; } = null;
    /// <summary>Gets or sets the ship-to city.</summary>
    public string? ShipToCity { get; set; } = null;
    /// <summary>Gets or sets the ship-to state.</summary>
    public string? ShipToState { get; set; } = null;
    /// <summary>Gets or sets the ship-to zip code.</summary>
    public string? ShipToZip { get; set; } = null;
    /// <summary>Gets or sets the ship-to country.</summary>
    public string? ShipToCountry { get; set; } = null;
    /// <summary>Gets or sets the ship-to method ID.</summary>
    public int? ShipToMethodID { get; set; } = null;
}