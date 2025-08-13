
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class OrderVersionStatusListResult : CommonResult
{
    [XmlArray("OrderVersionStatuses")]
    [XmlArrayItem("OrderVersionStatus")]
    public List<OrderVersionStatus>? OrderVersionStatuses { get; set; } = new List<OrderVersionStatus>();
}

public class OrderVersionStatus
{
    public int OrderVersionStatusID { get; set; }
    public string Name { get; set; } = string.Empty;
}