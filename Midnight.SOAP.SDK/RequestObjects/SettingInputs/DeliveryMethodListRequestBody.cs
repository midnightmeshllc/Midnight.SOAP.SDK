
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("DeliveryMethodList")]
public class DeliveryMethodListRequestBody
{
    public required DeliveryMethodListInputParameter InputParameter { get; set; }
}

public class DeliveryMethodListInputParameter
{
    public int? DeliveryMethodID { get; set; }
    public string? DeliveryMethodName { get; set; } = string.Empty;
    public bool Active { get; set; } = true;
}