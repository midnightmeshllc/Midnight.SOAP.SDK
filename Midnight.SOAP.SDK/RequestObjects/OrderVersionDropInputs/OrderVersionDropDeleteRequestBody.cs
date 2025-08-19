
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;

[XmlRoot("OrderVersionDropDelete")]
public class OrderVersionDropDeleteRequestBody
{
    public required OrderVersionDropDeleteinputParameter InputParameter { get; set; }
}

public class OrderVersionDropDeleteinputParameter
{
    public required int OrderVersionDropID { get; set; }
}