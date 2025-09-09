using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;

/// <summary>
/// Represents the result of a quick add operation for an order version in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionQuickAddResult : CommonResult
{
    /// <summary>
    /// Gets or sets the order information for the quick add result.
    /// </summary>
    [XmlElement("Order")]
    public OrderVersionQuickAddResultOrder? Order { get; set; }
}

/// <summary>
/// Represents the order information in the quick add result for an order version.
/// </summary>
public class OrderVersionQuickAddResultOrder
{
    /// <summary>Gets or sets the order ID.</summary>
    [XmlElement("OrderID")]
    public int OrderID { get; set; }
    /// <summary>Gets or sets the order number.</summary>
    [XmlElement("OrderNumber")]
    public string? OrderNumber { get; set; }
    /// <summary>Gets or sets the version information for the order.</summary>
    [XmlElement("Version")]
    public OrderVersionQuickAddResultVersion? Version { get; set; }
}

/// <summary>
/// Represents the version information in the quick add result for an order version.
/// </summary>
public class OrderVersionQuickAddResultVersion
{
    /// <summary>Gets or sets the version ID.</summary>
    [XmlElement("VersionID")]
    public int VersionID { get; set; }
    /// <summary>Gets or sets the version suffix.</summary>
    [XmlElement("VersionSuffix")]
    public int VersionSuffix { get; set; }
    /// <summary>Gets or sets the version name.</summary>
    [XmlElement("VersionName")]
    public string? VersionName { get; set; }
    /// <summary>Gets or sets the version quantity.</summary>
    [XmlElement("VersionQuantity")]
    public int VersionQuantity { get; set; }
}