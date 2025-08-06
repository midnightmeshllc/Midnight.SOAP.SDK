
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.DJBInputs;

[XmlRoot("DJBStatusList")]
public class DJBJobStatusListRequestBody
{
    public required DJBStatusListInputParameter InputParameter { get; set; }
}

public class DJBStatusListInputParameter
{
    public int? DJBJobStatusID { get; set; }
    public string? Status { get; set; } = string.Empty;
}