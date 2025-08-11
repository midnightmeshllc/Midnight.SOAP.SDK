
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;

[XmlRoot("OrderVersionDetailEstimatedTime")]
public class OrderVersionDetailEstimatedTimeRequestBody
{
    public required OrderVersionDetailEstimatedTimeInputParameter InputParameter { get; set; }
}

public class OrderVersionDetailEstimatedTimeInputParameter : UserDefinedFieldsFirst10
{
    public int? OrderID { get; set; }
    public int? VersionID { get; set; }
    public int OrderVersionDetailID { get; set; }
    public int? ServiceID { get; set; }
}