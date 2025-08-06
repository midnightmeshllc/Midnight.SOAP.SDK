using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("InventoryItemLotList")]
public class InventoryItemLotListRequestBody
{
    public required InventoryItemLotListInputParameter InputParameter { get; set; }
}

public class InventoryItemLotListInputParameter
{
    public int ItemID { get; set; }
}