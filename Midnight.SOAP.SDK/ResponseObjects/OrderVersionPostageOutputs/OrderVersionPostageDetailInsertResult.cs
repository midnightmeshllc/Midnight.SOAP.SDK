using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

/// <summary>
/// Represents the result of inserting an order version postage detail in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionPostageDetailInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted order version postage detail.
    /// </summary>
    [XmlElement("OrderVersionPostageDetailID")]
    public int OrderVersionPostageDetailID { get; set; }
}
