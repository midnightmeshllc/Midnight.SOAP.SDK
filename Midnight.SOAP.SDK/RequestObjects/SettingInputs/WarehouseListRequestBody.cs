
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("WarehouseList")]
public class WarehouseListRequestBody
{
    public required WarehouseListInputParameter InputParameter { get; set; }
}

public class WarehouseListInputParameter
{
    public int? WarehouseID { get; set; }
    public string? Name { get; set; }
    public int? DefaultReceivingID { get; set; }
}