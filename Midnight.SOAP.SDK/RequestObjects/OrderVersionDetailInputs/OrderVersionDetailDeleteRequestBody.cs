
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailDelete")]
public class OrderVersionDetailDeleteRequestBody
{
    public required OrderVersionDetailDeleteInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailDeleteInputParameter
{
    public required int OrderVersionDetailID { get; set; }
}