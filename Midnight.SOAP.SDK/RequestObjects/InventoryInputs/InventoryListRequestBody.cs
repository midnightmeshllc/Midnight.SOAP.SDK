using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryInputs;

[XmlRoot("InventoryList")]
public class InventoryListRequestBody
{
    public required InventoryListInputParameter InputParameter { get; set; }
}

public class InventoryListInputParameter
{
    public required List<InventoryListItem> Item { get; set; }
}

public class InventoryListItem
{
    public int ItemID { get; set; }
    public int? CustomerID { get; set; }
    public string? ItemTypeName { get; set; }
    public string? ItemCode { get; set; }
    public string? ItemName { get; set; }
    public string? ItemDescription { get; set; }
    public bool? Active { get; set; }
}