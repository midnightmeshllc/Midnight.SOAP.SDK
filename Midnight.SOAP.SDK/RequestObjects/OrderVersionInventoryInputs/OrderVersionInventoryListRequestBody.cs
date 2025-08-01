using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;

[XmlRoot("OrderVersionInventoryList")]
public class OrderVersionInventoryListRequestBody
{
    public required OrderVersionInventoryListInputParameter InputParameter { get; set; }
}

public class OrderVersionInventoryListInputParameter
{
    public int VersionID { get; set; }
}