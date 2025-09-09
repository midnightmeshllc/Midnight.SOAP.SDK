using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;

/// <summary>
/// Represents the result of inserting an order version drop in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionDropInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted order version drop.
    /// </summary>
    [XmlElement("OrderVersionDropID")]
    public int OrderVersionDropID { get; set; }
}
