
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("OrderStatusList")]
public class OrderStatusListRequestBody
{
    public required OrderStatusListInputParameter InputParameter { get; set; }
}

public class OrderStatusListInputParameter
{
    public int? OrderStatusID { get; set; }
    public string? OrderStatusName { get; set; }
    public string? OrderStatusType { get; set; }
    public bool Active { get; set; } = true;
}