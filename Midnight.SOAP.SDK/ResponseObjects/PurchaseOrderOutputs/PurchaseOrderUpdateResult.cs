using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.PurchaseOrderOutputs;

/// <summary>
/// Represents the result of a purchase order update operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class PurchaseOrderUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated purchase order.
    /// </summary>
    public int? PurchaseOrderID { get; set; }
}
