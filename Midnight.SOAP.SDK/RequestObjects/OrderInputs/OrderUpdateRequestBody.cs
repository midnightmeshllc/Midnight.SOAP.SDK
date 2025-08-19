using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

[XmlRoot("OrderUpdate")]
public class OrderUpdateRequestBody
{
    public required OrderUpdateInputParameter InputParameter { get; set; }
}

public class OrderUpdateInputParameter : UserDefinedFields
{
    public required int OrderID { get; set; }
    public int? CustomerID { get; set; } = null;
    public int? ContactID { get; set; } = null;
    public int? SalesRepID { get; set; } = null;
    public string? CSRID { get; set; } = null;
    public string? ProjectName { get; set; } = null;
    public string? PONumber { get; set; } = null;
    public string? Terms { get; set; } = null;
    public bool? Taxable { get; set; } = null;
    public int? OrderStatusID { get; set; } = null;
    public string? OrderDate { get; set; } = null;
    public string? DataInDate { get; set; } = null;
    public bool? DataInYN { get; set; } = null;
    public string? MaterialInDate { get; set; } = null;
    public bool? MaterialInYN { get; set; } = true;
    public string? ArtworkInDate { get; set; } = null;
    public bool? ArtworkInYN { get; set; } = null;
    public string? DueDate { get; set; } = null;
    public bool? DueDateYN { get; set; } = null;
    public string? TimeDue { get; set; } = null;
    public string? ShipDate { get; set; } = null;
    public string? CloseDate { get; set; } = null;
    public int? ExpectedQty { get; set; } = null;
    public int? ResidualInstructionID { get; set; } = null;
    public string? ResidualShipTo { get; set; } = null;
    public string? OrderNumber { get; set; } = null;
    public string? JobProgressCode { get; set; } = null;
    public int? JobPriorityID { get; set; } = null;
    public int? JobFrequencyID { get; set; } = null;
    public int? JobTypeID { get; set; } = null;
    public string? InvoiceComments { get; set; } = null;
    public OrderUpdateShipToAddress? ShippingAddress { get; set; } = null;
    public OrderUpdateBillToAddress? BillingAddress { get; set; } = null;
    public string? ShippingComments { get; set; } = null;

}

public class OrderUpdateBillToAddress
{
    public int? BillToContactID { get; set; } = null;
    public string? BillToName { get; set; } = null;
    public string? BillToAddressLine1 { get; set; } = null;
    public string? BillToAddressLine2 { get; set; } = null;
    public string? BillToAddressLine3 { get; set; } = null;
    public string? BillToCity { get; set; } = null;
    public string? BillToState { get; set; } = null;
    public string? BillToZip { get; set; } = null;
    public string? BillToCountry { get; set; } = null;
}

public class OrderUpdateShipToAddress
{
    public int? ShipToContactID { get; set; } = null;
    public string? ShipToName { get; set; } = null;
    public string? ShipToAddressLine1 { get; set; } = null;
    public string? ShipToAddressLine2 { get; set; } = null;
    public string? ShipToAddressLine3 { get; set; } = null;
    public string? ShipToCity { get; set; } = null;
    public string? ShipToState { get; set; } = null;
    public string? ShipToZip { get; set; } = null;
    public string? ShipToCountry { get; set; } = null;
    public int? ShipToMethodID { get; set; } = null;
}