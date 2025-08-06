using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.CommonObjects;

public class CommonResult
{
    public int ReturnCode { get; set; }
    [XmlElement("ReturnErrors")]
    public List<ReturnError> ReturnErrors { get; set; } = new List<ReturnError>();
}

public class ReturnError
{
    [XmlElement("Error")]
    public string? Error { get; set; }
}