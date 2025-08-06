
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class DeliveryMethodListResult : CommonResult
{
    [XmlArray("DeliveryMethods")]
    [XmlArrayItem("DeliveryMethod")]
    public List<DeliveryMethod> DeliveryMethods { get; set; } = new List<DeliveryMethod>();
}

public class DeliveryMethod
{
    public int DeliveryMethodID { get; set; }
    public string? DeliveryMethodName { get; set; } = string.Empty;
}