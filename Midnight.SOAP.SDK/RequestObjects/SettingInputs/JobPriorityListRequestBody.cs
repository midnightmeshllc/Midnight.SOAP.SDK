
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.SettingInputs;

[XmlRoot("JobPriorityList")]
public class JobPriorityListRequestBody
{
    public required JobPriorityListInputParameter InputParameter { get; set; }
}

public class JobPriorityListInputParameter
{
    public int? JobPriorityID { get; set; }
    public string? JobPriorityDescription { get; set; }
    public bool Active { get; set; }
}