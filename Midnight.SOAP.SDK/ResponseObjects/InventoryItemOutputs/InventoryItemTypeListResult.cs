
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class InventoryItemTypeListResult :CommonResult
{
    [XmlArray("InventoryItemTypes")]
    [XmlArrayItem("InventoryItemType")]
    public List<InventoryItemType> InventoryItemTypes { get; set; } = new List<InventoryItemType>();
}

public class InventoryItemType
{
    public string? ItemTypeName { get; set; }
    public string? ItemTypeDescription { get; set; }
}