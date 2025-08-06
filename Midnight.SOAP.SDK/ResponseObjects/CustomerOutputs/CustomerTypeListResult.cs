
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerTypeListResult : CommonResult
{
    [XmlArray("CustomerTypes")]
    [XmlArrayItem("CustomerType")]
    public List<CustomerType> CustomerTypes { get; set; } = new List<CustomerType>();
}

public class CustomerType
{
    [XmlElement("CustomerTypeID")]
    public int CustomerTypeID { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; } = string.Empty;
}