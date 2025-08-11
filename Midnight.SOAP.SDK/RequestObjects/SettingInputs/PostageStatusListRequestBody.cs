
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("PostageStatusList")]
public class PostageStatusListRequestBody
{
    public required PostageStatusListInputParameter InputParameter { get; set; }
}

public class PostageStatusListInputParameter
{
    public int? PostageStatusID { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; } = true;
}