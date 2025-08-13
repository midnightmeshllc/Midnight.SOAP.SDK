using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageDetailInputs;

[XmlRoot("OrderVersionPostageDetailList")]
public class OrderVersionPostageDetailListRequestBody
{
    public required OrderVersionPostageDetailListInputParameter InputParameter { get; set; }
}

public class OrderVersionPostageDetailListInputParameter
{
    public required int OrderVersionPostageID { get; set; }
}