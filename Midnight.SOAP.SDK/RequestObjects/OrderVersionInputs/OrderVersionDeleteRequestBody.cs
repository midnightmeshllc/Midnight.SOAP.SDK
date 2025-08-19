using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionDelete")]
public class OrderVersionDeleteRequestBody
{
    public required OrderVersionDeleteInputParameter InputParameter { get; set; }
}

public class OrderVersionDeleteInputParameter
{
    public required int VersionID { get; set; }
}