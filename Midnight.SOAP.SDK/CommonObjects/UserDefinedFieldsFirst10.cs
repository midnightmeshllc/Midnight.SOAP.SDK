namespace Midnight.SOAP.SDK.CommonObjects;

using System.Xml.Serialization;

public class UserDefinedFieldsFirst10
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
    [XmlElement("UDF6")]
    public UDFValue? UDF6 { get; set; }
    [XmlElement("UDF7")]
    public UDFValue? UDF7 { get; set; }
    [XmlElement("UDF8")]
    public UDFValue? UDF8 { get; set; }
    [XmlElement("UDF9")]
    public UDFValue? UDF9 { get; set; }
    [XmlElement("UDF10")]
    public UDFValue? UDF10 { get; set; }
}
