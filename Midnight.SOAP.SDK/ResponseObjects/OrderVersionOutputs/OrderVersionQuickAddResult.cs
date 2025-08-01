
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

[XmlRoot("Result")]
public class OrderVersionQuickAddResult : CommonResult
{
    public OrderVersionQuickAddResultOrder? Order { get; set; }
}

public class OrderVersionQuickAddResultOrder
{
    public int OrderID { get; set; }
    public string? OrderNumber { get; set; }
    public OrderVersionQuickAddResultVersion? Version { get; set; }
}

public class OrderVersionQuickAddResultVersion
{
    public int VersionID { get; set; }
    public int VersionSuffix { get; set; }
    public string? VersionName { get; set; }
    public int VersionQuantity { get; set; }
}