
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;

[XmlRoot("Result")]
public class CustomerContactInsertResult : CommonResult
{
    public int ContactID { get; set; }
}
