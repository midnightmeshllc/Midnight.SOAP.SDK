
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("WarehouseLocationList")]
public class WarehouseLocationListRequestBody
{
    public required WarehouseLocationListInputParameter InputParameter { get; set; }
}

public class WarehouseLocationListInputParameter
{
    public int? WarehouseLocationID { get; set; }
    public string? Description { get; set; }
    public string? Section { get; set; }
    public string? Bay { get; set; }
    public string? SlotShelf { get; set; }
    public int? SizeID { get; set; }
    public string? LocationType { get; set; }
    public int? WarehouseID { get; set; }
    public bool Active { get; set; } = true;
}