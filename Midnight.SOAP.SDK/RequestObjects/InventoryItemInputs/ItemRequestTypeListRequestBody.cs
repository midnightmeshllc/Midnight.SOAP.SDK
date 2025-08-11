
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

[XmlRoot("ItemRequestTypeList")]
public class ItemRequestTypeListRequestBody
{
    public required ItemRequestTypeListInputParameter InputParameter { get; set; }
}

public class ItemRequestTypeListInputParameter
{
    public int? ItemRequestTypeID { get; set; }
    public string? Description { get; set; }
}