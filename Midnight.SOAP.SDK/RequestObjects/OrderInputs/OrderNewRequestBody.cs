using Midnight.SOAP.SDK.CommonObjects;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

/// <summary>
/// Represents the request body for creating a new order in the Midnight SOAP API.
/// </summary>
public class OrderNewRequestBody
{
    /// <summary>
    /// Gets or sets the order input parameter.
    /// </summary>
    public required OrderNewInputParameter Order { get; set; }
}

/// <summary>
/// Represents the input parameter for creating a new order in the Midnight SOAP API.
/// </summary>
public class OrderNewInputParameter : UserDefinedFieldsFirst5
{
    /// <summary>Gets or sets the customer ID.</summary>
    public int CustomerID { get; set; }
    /// <summary>Gets or sets the order date.</summary>
    public string? OrderDate { get; set; }
    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    public int OrderNo { get; set; }
    /// <summary>Gets or sets the version name.</summary>
    public string? VersionName { get; set; }
    /// <summary>Gets or sets the invoice comments.</summary>
    public string? InvoiceComments { get; set; }
    /// <summary>Gets or sets the shipping address.</summary>
    public OrderShippingAddress? ShippingAddress { get; set; } = new OrderShippingAddress();
    /// <summary>Gets or sets the billing address.</summary>
    public OrderBillingAddress? BillingAddress { get; set; } = new OrderBillingAddress();
    /// <summary>Gets or sets the Pressero ID.</summary>
    public int PresseroId { get; set; }
    /// <summary>Gets or sets the quantity.</summary>
    public int Quantity { get; set; }
    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    /// <summary>Gets or sets the contact ID.</summary>
    public int ContactID { get; set; }
    /// <summary>Gets or sets the sales representative ID.</summary>
    public int SalesRepID { get; set; }
    /// <summary>Gets or sets the ship to name.</summary>
    public string? ShipToName { get; set; }
    /// <summary>Gets or sets the ship to method.</summary>
    public string? ShipToMethod { get; set; }
    /// <summary>Gets or sets the bill to name.</summary>
    public string? BillToName { get; set; }
    /// <summary>Gets or sets a value indicating whether the order is paid (Y/N).</summary>
    public char OrderPaidYN { get; set; }
    /// <summary>Gets or sets a value indicating whether payment was received.</summary>
    public bool PaymentReceived { get; set; }
    /// <summary>Gets or sets the surcharge amount on services.</summary>
    public int SurchargeAmountOnServices { get; set; }
    /// <summary>Gets or sets the surcharge amount on postage.</summary>
    public int SurchargeAmountOnPostage { get; set; }
    /// <summary>Gets or sets the surcharge amount on escrow earmarked.</summary>
    public int SurchargeAmountOnEscrowEarmarked { get; set; }
    /// <summary>Gets or sets the payment info.</summary>
    public PaymentInfo? PaymentInfo { get; set; }
    /// <summary>Gets or sets the PO number.</summary>
    public string? PONum { get; set; }
    /// <summary>Gets or sets the MOD order number.</summary>
    public string? MODOrderNum { get; set; }
    /// <summary>Gets or sets a value indicating whether to use the order number.</summary>
    public bool UseOrderNo { get; set; }
    /// <summary>Gets or sets the discount.</summary>
    public decimal Discount { get; set; }
    /// <summary>Gets or sets a value indicating whether to update press stock pricing (Y/N).</summary>
    public char UpdatePressStockPricingYN { get; set; }
    /// <summary>Gets or sets the order detail.</summary>
    public OrderDetail? OrderDetail { get; set; }
    /// <summary>Gets or sets the order inventory.</summary>
    public OrderInventory? OrderInventory { get; set; }
}

/// <summary>
/// Represents the inventory for an order in the Midnight SOAP API.
/// </summary>
public class OrderInventory
{
    /// <summary>Gets or sets the list of items.</summary>
    public List<Item> Items { get; set; } = new();
}

/// <summary>
/// Represents an item in the order inventory in the Midnight SOAP API.
/// </summary>
public class Item
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemId { get; set; }
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; }
    /// <summary>Gets or sets the quantity needed.</summary>
    public int QuantityNeeded { get; set; }
    /// <summary>Gets or sets the notes.</summary>
    public string? Notes { get; set; }
    /// <summary>Gets or sets the priority.</summary>
    public int Priority { get; set; }
}

/// <summary>
/// Represents the order detail in the Midnight SOAP API.
/// </summary>
public class OrderDetail
{
    /// <summary>Gets or sets the list of services.</summary>
    public List<Services>? Services { get; set; }
}

/// <summary>
/// Represents a service entry in the order detail in the Midnight SOAP API.
/// </summary>
public class Services
{
    /// <summary>Gets or sets the service.</summary>
    public Service Service { get; set; } = new Service();
}

/// <summary>
/// Represents a service in the Midnight SOAP API.
/// </summary>
public class Service
{
    /// <summary>Gets or sets the service ID.</summary>
    public int SvcId { get; set; }
    /// <summary>Gets or sets the service quantity.</summary>
    public decimal SvcQuantity { get; set; }
    /// <summary>Gets or sets the unit price.</summary>
    public decimal UnitPrice { get; set; }
    /// <summary>Gets or sets a value indicating whether the service is taxable.</summary>
    public bool Taxable { get; set; }
    /// <summary>Gets or sets the service hyperlink.</summary>
    public string? ServiceHyperlink { get; set; }
    /// <summary>Gets or sets the file location.</summary>
    public string? FileLocation { get; set; }
    /// <summary>Gets or sets the identifier.</summary>
    public string? Identifier { get; set; }
    /// <summary>Gets or sets a value indicating whether to use the identifier for service ID lookup.</summary>
    public bool IdentifierSvsIDLookup { get; set; }
    /// <summary>Gets or sets the item notes.</summary>
    public string? ItemNotes { get; set; }
    /// <summary>Gets or sets the wide format product type ID.</summary>
    public int WideFormatProductTypeID { get; set; }
    /// <summary>Gets or sets the print project type ID.</summary>
    public int PrintProjectTypeID { get; set; }
}

/// <summary>
/// Represents payment information for an order in the Midnight SOAP API.
/// </summary>
public class PaymentInfo
{
    /// <summary>Gets or sets the transaction ID.</summary>
    public int TransactionId { get; set; }
}

/// <summary>
/// Represents the shipping address for an order in the Midnight SOAP API.
/// </summary>
public class OrderShippingAddress
{
    /// <summary>Gets or sets the shipping address contact.</summary>
    public string? ShippingAddressContact { get; set; }
    /// <summary>Gets or sets the shipping address line 1.</summary>
    public string? ShippingAddressLine1 { get; set; }
    /// <summary>Gets or sets the shipping address line 2.</summary>
    public string? ShippingAddressLine2 { get; set; }
    /// <summary>Gets or sets the shipping address line 3.</summary>
    public string? ShippingAddressLine3 { get; set; }
    /// <summary>Gets or sets the shipping address city.</summary>
    public string? ShippingAddressCity { get; set; }
    /// <summary>Gets or sets the shipping address state.</summary>
    public string? ShippingAddressState { get; set; }
    /// <summary>Gets or sets the shipping address zip.</summary>
    public string? ShippingAddressZip { get; set; }
}

/// <summary>
/// Represents the billing address for an order in the Midnight SOAP API.
/// </summary>
public class OrderBillingAddress
{
    /// <summary>Gets or sets the billing address contact.</summary>
    public string? BillingAddressContact { get; set; }
    /// <summary>Gets or sets the billing address line 1.</summary>
    public string? BillingAddressLine1 { get; set; }
    /// <summary>Gets or sets the billing address line 2.</summary>
    public string? BillingAddressLine2 { get; set; }
    /// <summary>Gets or sets the billing address line 3.</summary>
    public string? BillingAddressLine3 { get; set; }
    /// <summary>Gets or sets the billing address city.</summary>
    public string? BillingAddressCity { get; set; }
    /// <summary>Gets or sets the billing address state.</summary>
    public string? BillingAddressState { get; set; }
    /// <summary>Gets or sets the billing address zip.</summary>
    public string? BillingAddressZip { get; set; }
}