
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("ServiceList")]
public class ServiceListRequestBody
{
    public required ServiceListInputParameter InputParameter { get; set; }
}

public class ServiceListInputParameter
{
    public int? ServiceID { get; set; }
    public int? ServiceTypeID { get; set; }
    public string? ServiceTypeCode { get; set; }
    public string? ServiceTypeName { get; set; }
    public string? ServiceCode { get; set; }
    public string? ServiceName { get; set; }
    public bool Active { get; set; } = true;
}