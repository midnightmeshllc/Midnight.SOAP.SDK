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
    public int? CustomerID { get; set; }
    public bool ShouldSerializeCustomerID() => CustomerID.HasValue;

    /// <summary>Gets or sets the contact ID.</summary>
    public int? ContactID { get; set; }
    public bool ShouldSerializeContactID() => ContactID.HasValue;

    /// <summary>Gets or sets the sales representative ID.</summary>
    public int? SalesRepID { get; set; }
    public bool ShouldSerializeSalesRepID() => SalesRepID.HasValue;

    /// <summary>Gets or sets the CSR ID.</summary>
    public string? CSRID { get; set; }
    public bool ShouldSerializeCSRID() => IsSet(CSRID);

    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    public bool ShouldSerializeProjectName() => IsSet(ProjectName);

    /// <summary>Gets or sets the purchase order number.</summary>
    public string? PONumber { get; set; }
    public bool ShouldSerializePONumber() => IsSet(PONumber);

    /// <summary>Gets or sets the terms.</summary>
    public string? Terms { get; set; }
    public bool ShouldSerializeTerms() => IsSet(Terms);

    /// <summary>Gets or sets a value indicating whether the order is taxable.</summary>
    public bool? Taxable { get; set; }
    public bool ShouldSerializeTaxable() => Taxable.HasValue;

    /// <summary>Gets or sets the order status ID.</summary>
    public int? OrderStatusID { get; set; }
    public bool ShouldSerializeOrderStatusID() => OrderStatusID.HasValue;

    /// <summary>Gets or sets the order date.</summary>
    public string? OrderDate { get; set; }
    public bool ShouldSerializeOrderDate() => IsSet(OrderDate);

    /// <summary>Gets or sets the data in date.</summary>
    public string? DataInDate { get; set; }
    public bool ShouldSerializeDataInDate() => IsSet(DataInDate);

    /// <summary>Gets or sets a value indicating whether data in is set.</summary>
    public bool? DataInYN { get; set; }
    public bool ShouldSerializeDataInYN() => DataInYN.HasValue;

    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; }
    public bool ShouldSerializeMaterialInDate() => IsSet(MaterialInDate);

    /// <summary>Gets or sets a value indicating whether material in is set.</summary>
    public bool? MaterialInYN { get; set; }
    public bool ShouldSerializeMaterialInYN() => MaterialInYN.HasValue;

    /// <summary>Gets or sets the artwork in date.</summary>
    public string? ArtworkInDate { get; set; }
    public bool ShouldSerializeArtworkInDate() => IsSet(ArtworkInDate);

    /// <summary>Gets or sets a value indicating whether artwork in is set.</summary>
    public bool? ArtworkInYN { get; set; }
    public bool ShouldSerializeArtworkInYN() => ArtworkInYN.HasValue;

    /// <summary>Gets or sets the due date.</summary>
    public string? DueDate { get; set; }
    public bool ShouldSerializeDueDate() => IsSet(DueDate);

    /// <summary>Gets or sets a value indicating whether due date is set.</summary>
    public bool? DueDateYN { get; set; }
    public bool ShouldSerializeDueDateYN() => DueDateYN.HasValue;

    /// <summary>Gets or sets the time due.</summary>
    public string? TimeDue { get; set; }
    public bool ShouldSerializeTimeDue() => IsSet(TimeDue);

    /// <summary>Gets or sets the ship date.</summary>
    public string? ShipDate { get; set; }
    public bool ShouldSerializeShipDate() => IsSet(ShipDate);

    /// <summary>Gets or sets the close date.</summary>
    public string? CloseDate { get; set; }
    public bool ShouldSerializeCloseDate() => IsSet(CloseDate);

    /// <summary>Gets or sets the expected quantity.</summary>
    public int? ExpectedQty { get; set; }
    public bool ShouldSerializeExpectedQty() => ExpectedQty.HasValue;

    /// <summary>Gets or sets the residual instruction ID.</summary>
    public int? ResidualInstructionID { get; set; }
    public bool ShouldSerializeResidualInstructionID() => ResidualInstructionID.HasValue;

    /// <summary>Gets or sets the residual ship to information.</summary>
    public string? ResidualShipTo { get; set; }
    public bool ShouldSerializeResidualShipTo() => IsSet(ResidualShipTo);

    /// <summary>Gets or sets the order number.</summary>
    public string? OrderNumber { get; set; }
    public bool ShouldSerializeOrderNumber() => IsSet(OrderNumber);

    /// <summary>Gets or sets the job progress code.</summary>
    public string? JobProgressCode { get; set; }
    public bool ShouldSerializeJobProgressCode() => IsSet(JobProgressCode);

    /// <summary>Gets or sets the job priority ID.</summary>
    public int? JobPriorityID { get; set; }
    public bool ShouldSerializeJobPriorityID() => JobPriorityID.HasValue;

    /// <summary>Gets or sets the job frequency ID.</summary>
    public int? JobFrequencyID { get; set; }
    public bool ShouldSerializeJobFrequencyID() => JobFrequencyID.HasValue;

    /// <summary>Gets or sets the job type ID.</summary>
    public int? JobTypeID { get; set; }
    public bool ShouldSerializeJobTypeID() => JobTypeID.HasValue;

    /// <summary>Gets or sets the invoice comments.</summary>
    public string? InvoiceComments { get; set; }
    public bool ShouldSerializeInvoiceComments() => IsSet(InvoiceComments);

    /// <summary>Gets or sets the shipping address.</summary>
    public OrderUpdateShipToAddress? ShippingAddress { get; set; }
    public bool ShouldSerializeShippingAddress() => ShippingAddress != null;

    /// <summary>Gets or sets the billing address.</summary>
    public OrderUpdateBillToAddress? BillingAddress { get; set; }
    public bool ShouldSerializeBillingAddress() => BillingAddress != null;

    /// <summary>Gets or sets the shipping comments.</summary>
    public string? ShippingComments { get; set; }
    public bool ShouldSerializeShippingComments() => IsSet(ShippingComments);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}

/// <summary>
/// Represents the billing address for an order update.
/// </summary>
public class OrderUpdateBillToAddress
{
    /// <summary>Gets or sets the bill-to contact ID.</summary>
    public int? BillToContactID { get; set; }
    public bool ShouldSerializeBillToContactID() => BillToContactID.HasValue;

    /// <summary>Gets or sets the bill-to name.</summary>
    public string? BillToName { get; set; }
    public bool ShouldSerializeBillToName() => IsSet(BillToName);

    /// <summary>Gets or sets the bill-to address line 1.</summary>
    public string? BillToAddressLine1 { get; set; }
    public bool ShouldSerializeBillToAddressLine1() => IsSet(BillToAddressLine1);

    /// <summary>Gets or sets the bill-to address line 2.</summary>
    public string? BillToAddressLine2 { get; set; }
    public bool ShouldSerializeBillToAddressLine2() => IsSet(BillToAddressLine2);

    /// <summary>Gets or sets the bill-to address line 3.</summary>
    public string? BillToAddressLine3 { get; set; }
    public bool ShouldSerializeBillToAddressLine3() => IsSet(BillToAddressLine3);

    /// <summary>Gets or sets the bill-to city.</summary>
    public string? BillToCity { get; set; }
    public bool ShouldSerializeBillToCity() => IsSet(BillToCity);

    /// <summary>Gets or sets the bill-to state.</summary>
    public string? BillToState { get; set; }
    public bool ShouldSerializeBillToState() => IsSet(BillToState);

    /// <summary>Gets or sets the bill-to zip code.</summary>
    public string? BillToZip { get; set; }
    public bool ShouldSerializeBillToZip() => IsSet(BillToZip);

    /// <summary>Gets or sets the bill-to country.</summary>
    public string? BillToCountry { get; set; }
    public bool ShouldSerializeBillToCountry() => IsSet(BillToCountry);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}

/// <summary>
/// Represents the shipping address for an order update.
/// </summary>
public class OrderUpdateShipToAddress
{
    /// <summary>Gets or sets the ship-to contact ID.</summary>
    public int? ShipToContactID { get; set; }
    public bool ShouldSerializeShipToContactID() => ShipToContactID.HasValue;

    /// <summary>Gets or sets the ship-to name.</summary>
    public string? ShipToName { get; set; }
    public bool ShouldSerializeShipToName() => IsSet(ShipToName);

    /// <summary>Gets or sets the ship-to address line 1.</summary>
    public string? ShipToAddressLine1 { get; set; }
    public bool ShouldSerializeShipToAddressLine1() => IsSet(ShipToAddressLine1);

    /// <summary>Gets or sets the ship-to address line 2.</summary>
    public string? ShipToAddressLine2 { get; set; }
    public bool ShouldSerializeShipToAddressLine2() => IsSet(ShipToAddressLine2);

    /// <summary>Gets or sets the ship-to address line 3.</summary>
    public string? ShipToAddressLine3 { get; set; }
    public bool ShouldSerializeShipToAddressLine3() => IsSet(ShipToAddressLine3);

    /// <summary>Gets or sets the ship-to city.</summary>
    public string? ShipToCity { get; set; }
    public bool ShouldSerializeShipToCity() => IsSet(ShipToCity);

    /// <summary>Gets or sets the ship-to state.</summary>
    public string? ShipToState { get; set; }
    public bool ShouldSerializeShipToState() => IsSet(ShipToState);

    /// <summary>Gets or sets the ship-to zip code.</summary>
    public string? ShipToZip { get; set; }
    public bool ShouldSerializeShipToZip() => IsSet(ShipToZip);

    /// <summary>Gets or sets the ship-to country.</summary>
    public string? ShipToCountry { get; set; }
    public bool ShouldSerializeShipToCountry() => IsSet(ShipToCountry);

    /// <summary>Gets or sets the ship-to method ID.</summary>
    public int? ShipToMethodID { get; set; }
    public bool ShouldSerializeShipToMethodID() => ShipToMethodID.HasValue;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}