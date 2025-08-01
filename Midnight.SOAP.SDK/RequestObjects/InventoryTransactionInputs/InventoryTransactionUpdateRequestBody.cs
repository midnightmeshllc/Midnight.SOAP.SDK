using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryTransactionInputs;

[XmlRoot("InventoryTransactionUpdate")]
public class InventoryTransactionUpdateRequestBody
{
    public required InventoryTransactionUpdateInputParameter InputParameter { get; set; }
}

public class InventoryTransactionUpdateInputParameter
{
    public required InventoryTransactionUpdateItem Item { get; set; }
}

public class InventoryTransactionUpdateItem
{
    public int ItemID { get; set; }
    public int ItemTransactionTypeID { get; set; }
    public int? FromWarehouseLocationID { get; set; }
    public int? ToWarehouseLocationID { get; set; }
    public int? Quantity { get; set; }
    public int? LotID { get; set; }
    public int? OrderID { get; set; }
    public int? ReasonCodeID { get; set; }
    public string? Comment { get; set; }
}