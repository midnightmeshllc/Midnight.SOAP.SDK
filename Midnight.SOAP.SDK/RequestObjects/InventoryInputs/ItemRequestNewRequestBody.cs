
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

[XmlRoot("ItemRequestNew")]
public class ItemRequestNewRequestBody
{
    public required ItemRequestNewInputParameter InputParameter { get; set; }
}

public class ItemRequestNewInputParameter
{
    public required List<ItemRequest> ItemRequests { get; set; } = new List<ItemRequest>();
}

public class ItemRequest
{
    public int ItemRequestTypeID { get; set; }
    public int CustomerVendorID { get; set; }
    public string? CustomerVendorType { get; set; }
    public int? OrderID { get; set; }
    public int? RequestedByEmployeeID { get; set; }
    public DateOnly DateNeeded { get; set; }
    public TimeOnly TimeNeeded { get; set; }
    public DateOnly DateDone { get; set; }
    public int? CompanyID { get; set; }
    public string? Comment { get; set; }
    public string? Company { get; set; }
    public string? Attention { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? ZipCode { get; set; }
    public string? CountryCode { get; set; }
    public int? DeliveryMethodID { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public bool Approved { get; set; }
    public List<ItemRequestDetail>? ItemRequestDetails { get; set; } = new List<ItemRequestDetail>();
}

public class ItemRequestDetail
{
    public int? ItemID { get; set; }
    public string? ItemCode { get; set; }
    public string? Description { get; set; }
    public int? RequestedQuantity { get; set; }
    public int? PulledQuantity { get; set; }
    public int? WarehouseLocationFromID { get; set; }
    public int? WarehouseLocationToID { get; set; }
}