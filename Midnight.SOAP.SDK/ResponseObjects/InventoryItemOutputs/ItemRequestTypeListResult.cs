using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class ItemRequestTypeListResult : CommonResult
{
    [XmlArray("ItemRequestTypes")]
    [XmlArrayItem("ItemRequestType")]
    public List<ItemRequestType> ItemRequestTypes { get; set; } = new List<ItemRequestType>();
}

public class ItemRequestType
{
    public int ItemRequestTypeID { get; set; }
    public string? Description { get; set; }
}