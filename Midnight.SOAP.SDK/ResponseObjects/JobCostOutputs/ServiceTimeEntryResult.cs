using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

[XmlRoot("Result")]
public class ServiceTimeEntryResult : CommonResult
{
    [XmlElement("JobCostID")]
    public int JobCostID { get; set; }
}
