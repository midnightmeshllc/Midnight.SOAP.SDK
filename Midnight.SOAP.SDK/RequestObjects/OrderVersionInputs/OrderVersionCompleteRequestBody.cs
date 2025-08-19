
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionComplete")]
public class OrderVersionCompleteRequestBody
{
    public required OrderVersionCompleteInputParameter InputParameter { get; set; }
}

public class OrderVersionCompleteInputParameter
{
    public required int VersionID { get; set; }
    public required bool Complete { get; set; }
}