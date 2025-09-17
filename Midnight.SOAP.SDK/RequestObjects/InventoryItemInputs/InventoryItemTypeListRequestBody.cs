using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;

/// <summary>
/// Represents the request body for listing inventory item types in the Midnight SOAP API.
/// </summary>
[XmlRoot("InventoryItemTypeList")]
public class InventoryItemTypeListRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the inventory item type list request.
    /// </summary>
    public required InventoryItemTypeListInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for listing inventory item types in the Midnight SOAP API.
/// </summary>
public class InventoryItemTypeListInputParameter
{
    /// <summary>Gets or sets the item type name.</summary>
    public string? ItemTypeName { get; set; } = null;
    /// <summary>Gets or sets the item type description.</summary>
    public string? ItemTypeDescription { get; set; } = null;
}