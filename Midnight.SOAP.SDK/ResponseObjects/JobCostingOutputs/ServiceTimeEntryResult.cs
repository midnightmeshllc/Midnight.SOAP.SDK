
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostingOutputs;

[XmlRoot("Result")]
public class ServiceTimeEntryResult : CommonResult
{
    public int JobCostID { get; set; }
}
