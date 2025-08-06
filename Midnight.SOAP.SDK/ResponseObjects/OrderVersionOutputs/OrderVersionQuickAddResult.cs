using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

[XmlRoot("Result")]
public class OrderVersionQuickAddResult : CommonResult
{
    [XmlElement("Order")]
    public OrderVersionQuickAddResultOrder? Order { get; set; }
}

public class OrderVersionQuickAddResultOrder
{
    [XmlElement("OrderID")]
    public int OrderID { get; set; }
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
    [XmlElement("Version")]
    public OrderVersionQuickAddResultVersion? Version { get; set; }
}

public class OrderVersionQuickAddResultVersion
{
    [XmlElement("VersionID")]
    public int VersionID { get; set; }
    [XmlElement("VersionSuffix")]
    public int VersionSuffix { get; set; }
    [XmlElement("VersionName")]
    public string? VersionName { get; set; }
    [XmlElement("VersionQuantity")]
    public int VersionQuantity { get; set; }
}