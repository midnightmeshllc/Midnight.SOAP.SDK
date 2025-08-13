
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

[XmlRoot("Result")]
public class WarehouseLocationListResult : CommonResult
{
    [XmlArray("WarehouseLocations")]
    [XmlArrayItem("WarehouseLocation")]
    public List<WarehouseLocation> WarehouseLocations { get; set; } = new List<WarehouseLocation>();
}

public class WarehouseLocation
{
    public int? WarehouseLocationID { get; set; }
    public string? WarehouseLocationDescription { get; set; }
    public string? Section { get; set; }
    public string? Bay { get; set; }
    public string? SlotShelf { get; set; }
    public int? SizeID { get; set; }
    public string? WarehouseSizeDescription { get; set; }
    public string? LocationType { get; set; }
    public int? WarehouseID { get; set; }
    public string? WarehouseName { get; set; }

    [XmlElement("Active")]
    public string? ActiveRaw { get; set; }

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