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
    [XmlElement(IsNullable = true)]
    public string? CustomerVendorType { get; set; }
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? OrderID { get; set; }
    /// <summary>Gets or sets the requested by employee ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? RequestedByEmployeeID { get; set; }
    /// <summary>Gets or sets the date needed.</summary>
    public DateOnly DateNeeded { get; set; }
    /// <summary>Gets or sets the time needed.</summary>
    public TimeOnly TimeNeeded { get; set; }
    /// <summary>Gets or sets the date done.</summary>
    public DateOnly DateDone { get; set; }
    /// <summary>Gets or sets the company ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? CompanyID { get; set; }
    /// <summary>Gets or sets the comment.</summary>
    [XmlElement(IsNullable = true)]
    public string? Comment { get; set; }
    /// <summary>Gets or sets the company name.</summary>
    [XmlElement(IsNullable = true)]
    public string? Company { get; set; }
    /// <summary>Gets or sets the attention line.</summary>
    [XmlElement(IsNullable = true)]
    public string? Attention { get; set; }
    /// <summary>Gets or sets address line 1.</summary>
    [XmlElement(IsNullable = true)]
    public string? AddressLine1 { get; set; }
    /// <summary>Gets or sets address line 2.</summary>
    [XmlElement(IsNullable = true)]
    public string? AddressLine2 { get; set; }
    /// <summary>Gets or sets address line 3.</summary>
    [XmlElement(IsNullable = true)]
    public string? AddressLine3 { get; set; }
    /// <summary>Gets or sets the city.</summary>
    [XmlElement(IsNullable = true)]
    public string? City { get; set; }
    /// <summary>Gets or sets the state code.</summary>
    [XmlElement(IsNullable = true)]
    public string? StateCode { get; set; }
    /// <summary>Gets or sets the zip code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ZipCode { get; set; }
    /// <summary>Gets or sets the country code.</summary>
    [XmlElement(IsNullable = true)]
    public string? CountryCode { get; set; }
    /// <summary>Gets or sets the delivery method ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? DeliveryMethodID { get; set; }
    /// <summary>Gets or sets the phone number.</summary>
    [XmlElement(IsNullable = true)]
    public string? Phone { get; set; }
    /// <summary>Gets or sets the email address.</summary>
    [XmlElement(IsNullable = true)]
    public string? Email { get; set; }
    /// <summary>Gets or sets a value indicating whether the request is approved.</summary>
    [XmlElement(IsNullable = true)]
    public bool? Approved { get; set; }
    /// <summary>Gets or sets the list of item request details.</summary>
    [XmlElement(IsNullable = true)]
    public List<ItemRequestDetail>? ItemRequestDetails { get; set; }
}
/// <summary>
/// Represents the details of an item request in the Midnight SOAP API.
/// </summary>
public class ItemRequestDetail
{
    /// <summary>Gets or sets the item ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? ItemID { get; set; }
    /// <summary>Gets or sets the item code.</summary>
    [XmlElement(IsNullable = true)]
    public string? ItemCode { get; set; }
    /// <summary>Gets or sets the description.</summary>
    [XmlElement(IsNullable = true)]
    public string? Description { get; set; }
    /// <summary>Gets or sets the requested quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? RequestedQuantity { get; set; }
    /// <summary>Gets or sets the pulled quantity.</summary>
    [XmlElement(IsNullable = true)]
    public int? PulledQuantity { get; set; }
    /// <summary>Gets or sets the source warehouse location ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? WarehouseLocationFromID { get; set; }
    /// <summary>Gets or sets the destination warehouse location ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? WarehouseLocationToID { get; set; }
}