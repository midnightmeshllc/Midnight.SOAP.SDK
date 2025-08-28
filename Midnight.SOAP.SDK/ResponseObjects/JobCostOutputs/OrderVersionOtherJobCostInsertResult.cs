using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;

/// <summary>
/// Represents the result of inserting an order version other job cost in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionOtherJobCostInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the output details for the inserted order version other job cost.
    /// </summary>
    [XmlElement("OrderVersionOtherJobCostInsertOutput")]
    public OrderVersionOtherJobCostInsertOutput? OrderVersionOtherJobCostInsertOutput { get; set; }
}

/// <summary>
/// Represents the output details for an inserted order version other job cost in the Midnight SOAP API.
/// </summary>
public class OrderVersionOtherJobCostInsertOutput
{
    /// <summary>Gets or sets the order version other job cost ID.</summary>
    [XmlElement("OrderVersionOtherJobCostID")]
    public int OrderVersionOtherJobCostID { get; set; }
}