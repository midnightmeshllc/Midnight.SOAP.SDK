
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;

[XmlRoot("Result")]
public class CustomerInsertResult : CommonResult
{
    public int CustomerID { get; set; }
}
