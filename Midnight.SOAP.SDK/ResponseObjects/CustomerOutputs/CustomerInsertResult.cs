using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerInsertResult : CommonResult
{
    [XmlElement("CustomerID")]
    public int CustomerID { get; set; }
}
