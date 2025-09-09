using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for listing inventory item lots in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryItemLotList")]
public class InventoryItemLotListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory item lot list request.
    /// </summary>
    public required InventoryItemLotListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing inventory item lots in the Midnight SOAP API.
/// </summary>
public class InventoryItemLotListInputParameter
{
    /// <summary>Gets or sets the item ID.</summary>
    public int ItemID { get; set; }
}