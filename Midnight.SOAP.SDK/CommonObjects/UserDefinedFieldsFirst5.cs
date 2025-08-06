namespace Midnight.SOAP.SDK.CommonObjects;

using System.Xml.Serialization;

public class UserDefinedFieldsFirst5
{
    [XmlElement("UDF1")]
    public string? UDF1 { get; set; }
    [XmlElement("UDF2")]
    public string? UDF2 { get; set; }
    [XmlElement("UDF3")]
    public string? UDF3 { get; set; }
    [XmlElement("UDF4")]
    public string? UDF4 { get; set; }
    [XmlElement("UDF5")]
    public string? UDF5 { get; set; }
}
