using Midnight.SOAP.SDK.CommonObjects;
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
    [XmlArray("PurchaseOrders")]
    [XmlArrayItem("PurchaseOrder")]
    public required List<PurchaseOrderUpdateInput> PurchaseOrders { get; set; } = new List<PurchaseOrderUpdateInput>();
}

/// <summary>
/// Represents a purchase order update input in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderUpdateInput : PurchaseOrder_UserDefinedFields
{
    /// <summary>Gets or sets the purchase order ID.</summary>
    public required int PurchaseOrderID { get; set; }

    /// <summary>Gets or sets the purchase order type.</summary>
    public string? PurchaseOrderType { get; set; }
    public bool ShouldSerializePurchaseOrderType() => IsSet(PurchaseOrderType);

    /// <summary>Gets or sets the vendor ID.</summary>
    public required int VendorID { get; set; }

    /// <summary>Gets or sets the vendor contact ID.</summary>
    public int? VendorContactID { get; set; }
    public bool ShouldSerializeVendorContactID() => VendorContactID.HasValue;

    /// <summary>Gets or sets the vendor contact name.</summary>
    public string? VendorContactName { get; set; }
    public bool ShouldSerializeVendorContactName() => IsSet(VendorContactName);

    /// <summary>Gets or sets the employee ID who ordered.</summary>
    public int? OrderedByEmployeeID { get; set; }
    public bool ShouldSerializeOrderedByEmployeeID() => OrderedByEmployeeID.HasValue;

    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; }
    public bool ShouldSerializeOrderID() => OrderID.HasValue;

    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; }
    public bool ShouldSerializeCompanyID() => CompanyID.HasValue;

    /// <summary>Gets or sets the invoice number.</summary>
    public string? InvoiceNumber { get; set; }
    public bool ShouldSerializeInvoiceNumber() => IsSet(InvoiceNumber);

    /// <summary>Gets or sets the phone number.</summary>
    public int? Phone { get; set; }
    public bool ShouldSerializePhone() => Phone.HasValue;

    /// <summary>Gets or sets the fax number.</summary>
    public int? Fax { get; set; }
    public bool ShouldSerializeFax() => Fax.HasValue;

    /// <summary>Gets or sets the email address.</summary>
    public string? EmailAddress { get; set; }
    public bool ShouldSerializeEmailAddress() => IsSet(EmailAddress);

    /// <summary>Gets or sets the terms code.</summary>
    public string? TermsCode { get; set; }
    public bool ShouldSerializeTermsCode() => IsSet(TermsCode);

    /// <summary>Gets or sets the project name.</summary>
    public string? ProjectName { get; set; }
    public bool ShouldSerializeProjectName() => IsSet(ProjectName);

    /// <summary>Gets or sets the enter date.</summary>
    public string? EnterDate { get; set; }
    public bool ShouldSerializeEnterDate() => IsSet(EnterDate);

    /// <summary>Gets or sets the invoice date.</summary>
    public string? InvoiceDate { get; set; }
    public bool ShouldSerializeInvoiceDate() => IsSet(InvoiceDate);

    /// <summary>Gets or sets the ship date.</summary>
    public string? ShipDate { get; set; }
    public bool ShouldSerializeShipDate() => IsSet(ShipDate);

    /// <summary>Gets or sets the close date.</summary>
    public string? CloseDate { get; set; }
    public bool ShouldSerializeCloseDate() => IsSet(CloseDate);

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    public bool ShouldSerializeComment() => IsSet(Comment);

    /// <summary>Gets or sets the ship to company.</summary>
    public string? ShipToCompany { get; set; }
    public bool ShouldSerializeShipToCompany() => IsSet(ShipToCompany);

    /// <summary>Gets or sets the ship to attention line.</summary>
    public string? ShipToAttnLine { get; set; }
    public bool ShouldSerializeShipToAttnLine() => IsSet(ShipToAttnLine);

    /// <summary>Gets or sets the ship to address line 1.</summary>
    public string? ShipToAddressLine1 { get; set; }
    public bool ShouldSerializeShipToAddressLine1() => IsSet(ShipToAddressLine1);

    /// <summary>Gets or sets the ship to address line 2.</summary>
    public string? ShipToAddressLine2 { get; set; }
    public bool ShouldSerializeShipToAddressLine2() => IsSet(ShipToAddressLine2);

    /// <summary>Gets or sets the ship to address line 3.</summary>
    public string? ShipToAddressLine3 { get; set; }
    public bool ShouldSerializeShipToAddressLine3() => IsSet(ShipToAddressLine3);

    /// <summary>Gets or sets the ship to city.</summary>
    public string? ShipToCity { get; set; }
    public bool ShouldSerializeShipToCity() => IsSet(ShipToCity);

    /// <summary>Gets or sets the ship to state code.</summary>
    public string? ShipToStateCode { get; set; }
    public bool ShouldSerializeShipToStateCode() => IsSet(ShipToStateCode);

    /// <summary>Gets or sets the ship to zip code.</summary>
    public string? ShipToZipCode { get; set; }
    public bool ShouldSerializeShipToZipCode() => IsSet(ShipToZipCode);

    /// <summary>Gets or sets the ship to country code.</summary>
    public string? ShipToCountryCode { get; set; }
    public bool ShouldSerializeShipToCountryCode() => IsSet(ShipToCountryCode);

    /// <summary>Gets or sets the ship to delivery method ID.</summary>
    public int? ShipToDeliveryMethodID { get; set; }
    public bool ShouldSerializeShipToDeliveryMethodID() => ShipToDeliveryMethodID.HasValue;

    /// <summary>Gets or sets the bill to company.</summary>
    public string? BillToCompany { get; set; }
    public bool ShouldSerializeBillToCompany() => IsSet(BillToCompany);

    /// <summary>Gets or sets the bill to attention line.</summary>
    public string? BillToAttnLine { get; set; }
    public bool ShouldSerializeBillToAttnLine() => IsSet(BillToAttnLine);

    /// <summary>Gets or sets the bill to address line 1.</summary>
    public string? BillToAddressLine1 { get; set; }
    public bool ShouldSerializeBillToAddressLine1() => IsSet(BillToAddressLine1);

    /// <summary>Gets or sets the bill to address line 2.</summary>
    public string? BillToAddressLine2 { get; set; }
    public bool ShouldSerializeBillToAddressLine2() => IsSet(BillToAddressLine2);

    /// <summary>Gets or sets the bill to address line 3.</summary>
    public string? BillToAddressLine3 { get; set; }
    public bool ShouldSerializeBillToAddressLine3() => IsSet(BillToAddressLine3);

    /// <summary>Gets or sets the bill to city.</summary>
    public string? BillToCity { get; set; }
    public bool ShouldSerializeBillToCity() => IsSet(BillToCity);

    /// <summary>Gets or sets the bill to state code.</summary>
    public string? BillToStateCode { get; set; }
    public bool ShouldSerializeBillToStateCode() => IsSet(BillToStateCode);

    /// <summary>Gets or sets the bill to zip code.</summary>
    public string? BillToZipCode { get; set; }
    public bool ShouldSerializeBillToZipCode() => IsSet(BillToZipCode);

    /// <summary>Gets or sets the bill to country code.</summary>
    public string? BillToCountryCode { get; set; }
    public bool ShouldSerializeBillToCountryCode() => IsSet(BillToCountryCode);

    /// <summary>Gets or sets the actual invoice amount.</summary>
    public decimal? ActualInvoiceAmount { get; set; }
    public bool ShouldSerializeActualInvoiceAmount() => ActualInvoiceAmount.HasValue;

    /// <summary>Gets or sets the expected date.</summary>
    public string? ExpectedDate { get; set; }
    public bool ShouldSerializeExpectedDate() => IsSet(ExpectedDate);

    /// <summary>Gets or sets the list of purchase order items.</summary>
    [XmlArray("PurchaseOrderItems")]
    [XmlArrayItem("PurchaseOrderItem")]
    public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}

/// <summary>
/// Represents a purchase order item in the Midnight SOAP API.
/// </summary>
public class PurchaseOrderItem : PurchaseOrderItem_UserDefinedFieldsFirst15
{
    /// <summary>Gets or sets the purchase order item ID.</summary>
    public int? PurchaseOrderItemID { get; set; }
    public bool ShouldSerializePurchaseOrderItemID() => PurchaseOrderItemID.HasValue;

    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; }
    public bool ShouldSerializeItemID() => ItemID.HasValue;

    /// <summary>Gets or sets the item description.</summary>
    public string? Description { get; set; }
    public bool ShouldSerializeDescription() => IsSet(Description);

    // ItemQuantity as raw string for XML, with decimal property for code
    [XmlElement("ItemQuantity", IsNullable = true)]
    public string? ItemQuantityRaw { get; set; }
    public bool ShouldSerializeItemQuantityRaw() => IsSet(ItemQuantityRaw);

    [XmlIgnore]
    public decimal? ItemQuantity
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ItemQuantityRaw))
                return decimal.Zero;
            if (decimal.TryParse(ItemQuantityRaw, out var result))
                return result;
            return decimal.Zero;
        }
        set
        {
            ItemQuantityRaw = value?.ToString();
        }
    }

    // ItemPrice as raw string for XML, with decimal property for code
    [XmlElement("ItemPrice", IsNullable = true)]
    public string? ItemPriceRaw { get; set; }
    public bool ShouldSerializeItemPriceRaw() => IsSet(ItemPriceRaw);

    [XmlIgnore]
    public decimal? ItemPrice
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ItemPriceRaw))
                return decimal.Zero;
            if (decimal.TryParse(ItemPriceRaw, out var result))
                return result;
            return decimal.Zero;
        }
        set
        {
            ItemPriceRaw = value?.ToString();
        }
    }

    // MarkupPercentage as raw string for XML, with decimal property for code
    [XmlElement("MarkupPercentage", IsNullable = true)]
    public string? MarkupPercentageRaw { get; set; }
    public bool ShouldSerializeMarkupPercentageRaw() => IsSet(MarkupPercentageRaw);

    [XmlIgnore]
    public decimal? MarkupPercentage
    {
        get
        {
            if (string.IsNullOrWhiteSpace(MarkupPercentageRaw))
                return decimal.Zero;
            if (decimal.TryParse(MarkupPercentageRaw, out var result))
                return result;
            return decimal.Zero;
        }
        set
        {
            MarkupPercentageRaw = value?.ToString();
        }
    }

    /// <summary>Gets or sets the item order ID.</summary>
    public int? ItemOrderID { get; set; }
    public bool ShouldSerializeItemOrderID() => ItemOrderID.HasValue;

    /// <summary>Gets or sets the material in date.</summary>
    public string? MaterialInDate { get; set; }
    public bool ShouldSerializeMaterialInDate() => IsSet(MaterialInDate);

    /// <summary>Gets or sets the GLID.</summary>
    public string? GLID { get; set; }
    public bool ShouldSerializeGLID() => IsSet(GLID);

    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; }
    public bool ShouldSerializeItemCode() => IsSet(ItemCode);

    // QuantityReceived as raw string for XML, with decimal property for code
    [XmlElement("QuantityReceived", IsNullable = true)]
    public string? QuantityReceivedRaw { get; set; }
    public bool ShouldSerializeQuantityReceivedRaw() => IsSet(QuantityReceivedRaw);

    [XmlIgnore]
    public decimal? QuantityReceived
    {
        get
        {
            if (string.IsNullOrWhiteSpace(QuantityReceivedRaw))
                return decimal.Zero;
            if (decimal.TryParse(QuantityReceivedRaw, out var result))
                return result;
            return decimal.Zero;
        }
        set
        {
            QuantityReceivedRaw = value?.ToString();
        }
    }

    /// <summary>Gets or sets the expected date.</summary>
    public string? ExpectedDate { get; set; }
    public bool ShouldSerializeExpectedDate() => IsSet(ExpectedDate);

    /// <summary>Gets or sets the item estimate ID.</summary>
    public int? ItemEstimateID { get; set; }
    public bool ShouldSerializeItemEstimateID() => ItemEstimateID.HasValue;

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}