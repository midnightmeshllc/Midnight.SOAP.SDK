namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

public class OrderNewRequestBody
{
    public required OrderNewInputParameter Order { get; set; }
}

public class OrderNewInputParameter
{
    public int CustomerID { get; set; }
    public string? OrderDate { get; set; }
    public string? DueDate { get; set; }
    public int OrderNo { get; set; }
    public string? VersionName { get; set; }
    public string? InvoiceComments { get; set; }
    public ShippingAddress? ShippingAddress { get; set; } = new ShippingAddress();
    public BillingAddress? BillingAddress { get; set; } = new BillingAddress();
    public int PresseroId { get; set; }
    public int Quantity { get; set; }
    public string? ProjectName { get; set; }
    public int ContactID { get; set; }
    public int SalesRepID { get; set; }
    public string? ShipToName { get; set; }
    public string? ShipToMethod { get; set; }
    public string? BillToName { get; set; }
    public char OrderPaidYN { get; set; }
    public bool PaymentReceived { get; set; }
    public int SurchargeAmountOnServices { get; set; }
    public int SurchargeAmountOnPostage { get; set; }
    public int SurchargeAmountOnEscrowEarmarked { get; set; }
    public PaymentInfo? PaymentInfo { get; set; }
    public string? PONum { get; set; }
    public string? MODOrderNum { get; set; }
    public bool UseOrderNo { get; set; }
    public decimal Discount { get; set; }
    public char UpdatePressStockPricingYN { get; set; }
    public OrderDetail? OrderDetail { get; set; }
    public OrderInventory? OrderInventory { get; set; }

}

public class OrderInventory
{
    public List<Item> Items { get; set; } = new();
}

public class Item
{
    public int ItemId { get; set; }
    public string? Description { get; set; }
    public int QuantityNeeded { get; set; }
    public string? Notes { get; set; }
    public int Priority { get; set; }
}

public class OrderDetail
{
    public List<Services>? Services { get; set; }
}

public class Services
{
    public Service Service { get; set; } = new Service();
}

public class Service
{
    public int SvcId { get; set; }
    public decimal SvcQuantity { get; set; }
    public decimal UnitPrice { get; set; }
    public bool Taxable { get; set; }
    public string? ServiceHyperlink { get; set; }
    public string? FileLocation { get; set; }
    public string? Identifier { get; set; }
    public bool IdentifierSvsIDLookup { get; set; }
    public string? ItemNotes { get; set; }
    public int WideFormatProductTypeID { get; set; }
    public int PrintProjectTypeID { get; set; }
}

public class PaymentInfo
{
    public int TransactionId { get; set; }
}

public class ShippingAddress
{
    public string? ShippingAddressContact { get; set; }
    public string? ShippingAddressLine1 { get; set; }
    public string? ShippingAddressLine2 { get; set; }
    public string? ShippingAddressLine3 { get; set; }
    public string? ShippingAddressCity { get; set; }
    public string? ShippingAddressState { get; set; }
    public string? ShippingAddressZip { get; set; }
}

public class BillingAddress
{
    public string? BillingAddressContact { get; set; }
    public string? BillingAddressLine1 { get; set; }
    public string? BillingAddressLine2 { get; set; }
    public string? BillingAddressLine3 { get; set; }
    public string? BillingAddressCity { get; set; }
    public string? BillingAddressState { get; set; }
    public string? BillingAddressZip { get; set; }
}