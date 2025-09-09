using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of updating an inventory item lot in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryItemLotUpdateResult : CommonResult
{
    /// <summary>
    /// Gets or sets the unique identifier of the updated item lot.
    /// </summary>
    public int? ItemLotID { get; set; }
    /// <summary>
    /// Gets or sets the item lot number of the updated item lot.
    /// </summary>
    public string? ItemLotNumber { get; set; }
}
