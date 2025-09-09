using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a warehouse list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class WarehouseListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of warehouses returned by the request.
    /// </summary>
    [XmlArray("Warehouses")]
    [XmlArrayItem("Warehouse")]
    public List<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}

/// <summary>
/// Represents a warehouse in the Midnight SOAP API.
/// </summary>
public class Warehouse
{
    /// <summary>Gets or sets the warehouse ID.</summary>
    public int? WarehouseID { get; set; }
    /// <summary>Gets or sets the name of the warehouse.</summary>
    public string? Name { get; set; }
    /// <summary>Gets or sets the default receiving ID for the warehouse.</summary>
    public int? DefaultReceivingID { get; set; }
}