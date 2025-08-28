using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

/// <summary>
/// Represents the result of inserting an order version postage in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class OrderVersionPostageInsertResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the inserted order version postage.
    /// </summary>
    [XmlElement("OrderVersionPostageDetailID")]
    public int OrderVersionPostageID { get; set; }
}
