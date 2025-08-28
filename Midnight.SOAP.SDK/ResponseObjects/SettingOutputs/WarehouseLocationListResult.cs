using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a warehouse location list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class WarehouseLocationListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of warehouse locations returned by the request.
    /// </summary>
    [XmlArray("WarehouseLocations")]
    [XmlArrayItem("WarehouseLocation")]
    public List<WarehouseLocation> WarehouseLocations { get; set; } = new List<WarehouseLocation>();
}

/// <summary>
/// Represents a warehouse location in the Midnight SOAP API.
/// </summary>
public class WarehouseLocation
{
    /// <summary>Gets or sets the warehouse location ID.</summary>
    public int? WarehouseLocationID { get; set; }
    /// <summary>Gets or sets the description of the warehouse location.</summary>
    public string? WarehouseLocationDescription { get; set; }
    /// <summary>Gets or sets the section of the warehouse location.</summary>
    public string? Section { get; set; }
    /// <summary>Gets or sets the bay of the warehouse location.</summary>
    public string? Bay { get; set; }
    /// <summary>Gets or sets the slot or shelf of the warehouse location.</summary>
    public string? SlotShelf { get; set; }
    /// <summary>Gets or sets the size ID of the warehouse location.</summary>
    public int? SizeID { get; set; }
    /// <summary>Gets or sets the warehouse size description.</summary>
    public string? WarehouseSizeDescription { get; set; }
    /// <summary>Gets or sets the location type.</summary>
    public string? LocationType { get; set; }
    /// <summary>Gets or sets the warehouse ID.</summary>
    public int? WarehouseID { get; set; }
    /// <summary>Gets or sets the warehouse name.</summary>
    public string? WarehouseName { get; set; }

    /// <summary>Gets or sets the raw value indicating if the warehouse location is active.</summary>
    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

    /// <summary>Gets a value indicating whether the warehouse location is active.</summary>
    [XmlIgnore]
    public bool Active
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ActiveRaw)) return false;
            return string.Equals(ActiveRaw, "true", StringComparison.OrdinalIgnoreCase)
                || ActiveRaw == "1";
        }
    }

}