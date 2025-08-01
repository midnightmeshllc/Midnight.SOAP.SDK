
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostingOutputs;

[XmlRoot("Result")]
public class ProductionTimeEntryResult : CommonResult
{
    public int JobCostID { get; set; }
}
