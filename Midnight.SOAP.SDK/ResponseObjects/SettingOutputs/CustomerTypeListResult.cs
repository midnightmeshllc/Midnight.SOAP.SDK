using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;

/// <summary>
/// Represents the result of a customer type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class CustomerTypeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of customer types returned by the request.
    /// </summary>
    [XmlArray("CustomerTypes")]
    [XmlArrayItem("CustomerType")]
    public List<CustomerType> CustomerTypes { get; set; } = new List<CustomerType>();
}

/// <summary>
/// Represents a customer type in the Midnight SOAP API.
/// </summary>
public class CustomerType
{
    /// <summary>Gets or sets the customer type ID.</summary>
    [XmlElement("CustomerTypeID")]
    public int CustomerTypeID { get; set; }

    /// <summary>Gets or sets the name of the customer type.</summary>
    [XmlElement("Name")]
    public string Name { get; set; } = string.Empty;
}