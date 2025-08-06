using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("CustomerTypeList")]
public class CustomerTypeListRequestBody
{
    public required CustomerTypeListInputParameter InputParameter { get; set; }
}

public class CustomerTypeListInputParameter
{
    public int? CustomerTypeID { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; } = true;
}