namespace Midnight.SOAP.SDK.CommonObjects;

using System.Xml.Serialization;

public class UserDefinedFieldsFirst10
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
    [XmlElement("UDF6")]
    public string? UDF6 { get; set; }
    [XmlElement("UDF7")]
    public string? UDF7 { get; set; }
    [XmlElement("UDF8")]
    public string? UDF8 { get; set; }
    [XmlElement("UDF9")]
    public string? UDF9 { get; set; }
    [XmlElement("UDF10")]
    public string? UDF10 { get; set; }
}
