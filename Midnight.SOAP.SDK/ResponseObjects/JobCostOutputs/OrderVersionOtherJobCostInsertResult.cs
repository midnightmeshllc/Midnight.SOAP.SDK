
using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

[XmlRoot("Result")]
public class OrderVersionOtherJobCostInsertResult : CommonResult
{
    [XmlElement("OrderVersionOtherJobCostInsertOutput")]
    public OrderVersionOtherJobCostInsertOutput? OrderVersionOtherJobCostInsertOutput { get; set; }
}

public class OrderVersionOtherJobCostInsertOutput
{
    [XmlElement("OrderVersionOtherJobCostID")]
    public int OrderVersionOtherJobCostID { get; set; }
}