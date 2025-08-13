
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("OrderVersionStatusList")]
public class OrderVersionStatusListRequestBody
{
    public required OrderVersionStatusListInputParameter InputParameter { get; set; }
}

public class OrderVersionStatusListInputParameter
{
    public int? OrderVersionStatusID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}