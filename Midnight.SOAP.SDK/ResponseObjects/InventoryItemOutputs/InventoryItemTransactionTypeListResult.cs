using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

[XmlRoot("Result")]
public class InventoryItemTransactionTypeListResult : CommonResult
{
    [XmlArray("ItemTransactionTypes")]
    [XmlArrayItem("ItemTransactionType")]
    public List<ItemTransactionType> ItemTransactionTypes { get; set; } = new List<ItemTransactionType>();
}

public class ItemTransactionType
{
    public int? ItemTransactionTypeID { get; set; }
    public string? Description { get; set; }
}