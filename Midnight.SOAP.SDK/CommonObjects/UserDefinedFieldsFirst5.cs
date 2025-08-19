namespace Midnight.SOAP.SDK.CommonObjects;

using System.Xml.Serialization;

public class UserDefinedFieldsFirst5
{
    [XmlElement("UDF1")]
    public UDFValue? UDF1 { get; set; }
    [XmlElement("UDF2")]
    public UDFValue? UDF2 { get; set; }
    [XmlElement("UDF3")]
    public UDFValue? UDF3 { get; set; }
    [XmlElement("UDF4")]
    public UDFValue? UDF4 { get; set; }
    [XmlElement("UDF5")]
    public UDFValue? UDF5 { get; set; }
}
