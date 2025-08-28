namespace Midnight.SOAP.SDK.CommonObjects;

using System.Xml.Serialization;

/// <summary>
/// Represents the first 10 user defined fields for an entity in the Midnight SOAP API.
/// </summary>
public class UserDefinedFieldsFirst10
{
    /// <summary>Gets or sets UDF1.</summary>
    [XmlElement("UDF1")]
    public UDFValue? UDF1 { get; set; }
    /// <summary>Gets or sets UDF2.</summary>
    [XmlElement("UDF2")]
    public UDFValue? UDF2 { get; set; }
    /// <summary>Gets or sets UDF3.</summary>
    [XmlElement("UDF3")]
    public UDFValue? UDF3 { get; set; }
    /// <summary>Gets or sets UDF4.</summary>
    [XmlElement("UDF4")]
    public UDFValue? UDF4 { get; set; }
    /// <summary>Gets or sets UDF5.</summary>
    [XmlElement("UDF5")]
    public UDFValue? UDF5 { get; set; }
    /// <summary>Gets or sets UDF6.</summary>
    [XmlElement("UDF6")]
    public UDFValue? UDF6 { get; set; }
    /// <summary>Gets or sets UDF7.</summary>
    [XmlElement("UDF7")]
    public UDFValue? UDF7 { get; set; }
    /// <summary>Gets or sets UDF8.</summary>
    [XmlElement("UDF8")]
    public UDFValue? UDF8 { get; set; }
    /// <summary>Gets or sets UDF9.</summary>
    [XmlElement("UDF9")]
    public UDFValue? UDF9 { get; set; }
    /// <summary>Gets or sets UDF10.</summary>
    [XmlElement("UDF10")]
    public UDFValue? UDF10 { get; set; }
}
