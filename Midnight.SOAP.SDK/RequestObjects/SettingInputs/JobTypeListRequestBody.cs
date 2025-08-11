
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("JobTypeList")]
public class JobTypeListRequestBody
{
    public required JobTypeListInputParameter InputParameter { get; set; }
}

public class JobTypeListInputParameter
{
    public int? JobTypeID { get; set; }
    public string? JobTypeDescription { get; set; }
    public bool Active { get; set; } = true;
}