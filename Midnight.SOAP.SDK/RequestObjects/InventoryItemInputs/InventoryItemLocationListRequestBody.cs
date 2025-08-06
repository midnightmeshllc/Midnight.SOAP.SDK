using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("InventoryItemLocationList")]

public class InventoryItemLocationListRequestBody
{
    public required InventoryItemLocationListInputParameter InputParameter { get; set; }
}

public class InventoryItemLocationListInputParameter
{
    public int ItemID { get; set; }
    public int ItemLotID { get; set; }
    public int? WarehouseID { get; set; }
    public int? WarehouseLocationID { get; set; }
}