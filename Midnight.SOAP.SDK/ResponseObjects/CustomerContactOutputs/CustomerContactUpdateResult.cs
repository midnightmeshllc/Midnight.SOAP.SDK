
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;

[XmlRoot("Result")]
public class CustomerContactUpdateResult : CommonResult
{
    public int? ContactID { get; set; }
}
