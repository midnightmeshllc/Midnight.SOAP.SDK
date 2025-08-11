using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailList")]
public class OrderVersionDetailListRequestBody
{
    public required OrderVersionDetailListInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailListInputParameter
{
    public required int VersionID { get; set; }
}