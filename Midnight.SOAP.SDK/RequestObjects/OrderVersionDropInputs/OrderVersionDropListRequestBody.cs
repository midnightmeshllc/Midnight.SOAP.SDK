using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

[XmlRoot("OrderVersionDropList")]
public class OrderVersionDropListRequestBody
{
    public required OrderVersionDropListInputParameter InputParameter { get; set; }
}

public class OrderVersionDropListInputParameter
{
    public required int VersionID { get; set; }
}