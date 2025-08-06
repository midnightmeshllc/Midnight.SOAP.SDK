
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("InventoryItemTypeList")]
public class InventoryItemTypeListRequestBody
{
    public required InventoryItemTypeListInputParameter InputParameter { get; set; }
}

public class InventoryItemTypeListInputParameter
{
    public string? ItemTypeName { get; set; }
    public string? ItemTypeDescription { get; set; }
}