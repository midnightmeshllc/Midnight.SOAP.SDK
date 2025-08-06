using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("InventoryItemTransactionTypeList")]
public class InventoryItemTransactionTypeListRequestBody
{
    public required InventoryItemTransactionTypeListInputParameter InputParameter { get; set; }
}

public class InventoryItemTransactionTypeListInputParameter
{
    public int? ItemTransactionTypeID { get; set; }
    public string? Description { get; set; }
}