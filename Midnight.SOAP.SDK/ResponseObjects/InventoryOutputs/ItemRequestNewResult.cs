using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

/// <summary>
/// Represents the result of creating a new item request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class ItemRequestNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the new item request.
    /// </summary>
    [XmlElement("ItemRequestID")]
    public int ItemRequestID { get; set; }
}
