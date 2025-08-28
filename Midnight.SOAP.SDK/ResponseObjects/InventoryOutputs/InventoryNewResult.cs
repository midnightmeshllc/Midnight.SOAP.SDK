using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryOutputs;

/// <summary>
/// Represents the result of creating a new inventory item in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the new inventory item.
    /// </summary>
    [XmlElement("ItemID")]
    public int ItemID { get; set; }
    /// <summary>
    /// Gets or sets the creation date and time of the new inventory item.
    /// </summary>
    [XmlElement("ItemCode")]
    public DateTime? CreateDateTime { get; set; }
}
