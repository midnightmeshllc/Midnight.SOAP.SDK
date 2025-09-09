using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of an item request type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ItemRequestTypeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of item request types returned by the request.
    /// </summary>
    [XmlArray("ItemRequestTypes")]
    [XmlArrayItem("ItemRequestType")]
    public List<ItemRequestType> ItemRequestTypes { get; set; } = new List<ItemRequestType>();
}

/// <summary>
/// Represents an item request type in the Midnight SOAP API.
/// </summary>
public class ItemRequestType
{
    /// <summary>Gets or sets the item request type ID.</summary>
    public int ItemRequestTypeID { get; set; }
    /// <summary>Gets or sets the description of the item request type.</summary>
    public string? Description { get; set; }
}