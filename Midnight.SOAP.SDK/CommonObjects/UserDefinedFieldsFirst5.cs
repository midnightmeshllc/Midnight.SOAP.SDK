namespace Midnight.SOAP.SDK.CommonObjects;

using System.Xml.Serialization;

/// <summary>
/// Represents the first 5 user defined fields for an entity in the Midnight SOAP API.
/// </summary>
public class UserDefinedFieldsFirst5
{
    /// <summary>Gets or sets UDF1.</summary>
    [XmlElement("UDF1")]
    public UDFValue? UDF1 { get; set; } = null;
    /// <summary>Gets or sets UDF2.</summary>
    [XmlElement("UDF2")]
    public UDFValue? UDF2 { get; set; } = null;
    /// <summary>Gets or sets UDF3.</summary>
    [XmlElement("UDF3")]
    public UDFValue? UDF3 { get; set; } = null;
    /// <summary>Gets or sets UDF4.</summary>
    [XmlElement("UDF4")]
    public UDFValue? UDF4 { get; set; } = null;
    /// <summary>Gets or sets UDF5.</summary>
    [XmlElement("UDF5")]
    public UDFValue? UDF5 { get; set; } = null;
}
