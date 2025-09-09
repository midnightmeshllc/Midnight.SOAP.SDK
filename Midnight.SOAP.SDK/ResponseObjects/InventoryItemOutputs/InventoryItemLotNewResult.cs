using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of creating a new inventory item lot in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryItemLotNewResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the new item lot.
    /// </summary>
    [XmlElement("ItemLotID")]
    public int ItemLotID { get; set; }
    /// <summary>
    /// Gets or sets the item lot number of the new item lot.
    /// </summary>
    [XmlElement("ItemLotNumber")]
    public string? ItemLotNumber { get; set; }
}
