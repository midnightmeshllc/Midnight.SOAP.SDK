
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;

[XmlRoot("OrderVersionPostageList")]
public class OrderVersionPostageListRequestBody
{
    public required OrderVersionPostageListInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageListInputParameter
{
    public required int VersionID { get; set; }
}