using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

/// <summary>
/// Represents the request body for creating a new item request in the Midnight SOAP API.
/// </summary>
[XmlRoot("ItemRequestNew")]
public class ItemRequestNewRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the item request new request.
    /// </summary>
    public required ItemRequestNewInputParameter InputParameter { get; set; }
}
/// <summary>
/// Represents the input parameter for creating a new item request in the Midnight SOAP API.
/// </summary>
public class ItemRequestNewInputParameter
{
    /// <summary>Gets or sets the list of item requests.</summary>
    public required List<ItemRequest> ItemRequests { get; set; } = new List<ItemRequest>();
}
/// <summary>
/// Represents an item request in the Midnight SOAP API.
/// </summary>
public class ItemRequest : ItemRequest_UserDefinedFields
{
    /// <summary>Gets or sets the item request type ID.</summary>
    public int ItemRequestTypeID { get; set; }
    /// <summary>Gets or sets the customer or vendor ID.</summary>
    public int CustomerVendorID { get; set; }
    /// <summary>Gets or sets the customer or vendor type.</summary>
    public string? CustomerVendorType { get; set; } = null;
    /// <summary>Gets or sets the order ID.</summary>
    public int? OrderID { get; set; } = null;
    /// <summary>Gets or sets the requested by employee ID.</summary>
    public int? RequestedByEmployeeID { get; set; } = null;
    /// <summary>Gets or sets the date needed.</summary>
    public DateOnly DateNeeded { get; set; }
    /// <summary>Gets or sets the time needed.</summary>
    public TimeOnly TimeNeeded { get; set; }
    /// <summary>Gets or sets the date done.</summary>
    public DateOnly DateDone { get; set; }
    /// <summary>Gets or sets the company ID.</summary>
    public int? CompanyID { get; set; } = null;
    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; } = null;
    /// <summary>Gets or sets the company name.</summary>
    public string? Company { get; set; } = null;
    /// <summary>Gets or sets the attention line.</summary>
    public string? Attention { get; set; } = null;
    /// <summary>Gets or sets address line 1.</summary>
    public string? AddressLine1 { get; set; } = null;
    /// <summary>Gets or sets address line 2.</summary>
    public string? AddressLine2 { get; set; } = null;
    /// <summary>Gets or sets address line 3.</summary>
    public string? AddressLine3 { get; set; } = null;
    /// <summary>Gets or sets the city.</summary>
    public string? City { get; set; } = null;
    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; } = null;
    /// <summary>Gets or sets the zip code.</summary>
    public string? ZipCode { get; set; } = null;
    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; } = null;
    /// <summary>Gets or sets the delivery method ID.</summary>
    public int? DeliveryMethodID { get; set; } = null;
    /// <summary>Gets or sets the phone number.</summary>
    public string? Phone { get; set; } = null;
    /// <summary>Gets or sets the email address.</summary>
    public string? Email { get; set; } = null;
    /// <summary>Gets or sets a value indicating whether the request is approved.</summary>
    public bool? Approved { get; set; } = null;
    /// <summary>Gets or sets the list of item request details.</summary>
    public List<ItemRequestDetail>? ItemRequestDetails { get; set; } = new List<ItemRequestDetail>();
}
/// <summary>
/// Represents the details of an item request in the Midnight SOAP API.
/// </summary>
public class ItemRequestDetail
{
    /// <summary>Gets or sets the item ID.</summary>
    public int? ItemID { get; set; } = null;
    /// <summary>Gets or sets the item code.</summary>
    public string? ItemCode { get; set; } = null;
    /// <summary>Gets or sets the description.</summary>
    public string? Description { get; set; } = null;
    /// <summary>Gets or sets the requested quantity.</summary>
    public int? RequestedQuantity { get; set; } = null;
    /// <summary>Gets or sets the pulled quantity.</summary>
    public int? PulledQuantity { get; set; } = null;
    /// <summary>Gets or sets the source warehouse location ID.</summary>
    public int? WarehouseLocationFromID { get; set; } = null;
    /// <summary>Gets or sets the destination warehouse location ID.</summary>
    public int? WarehouseLocationToID { get; set; } = null;
}