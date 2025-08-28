using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;

/// <summary>
/// Represents the result of an inventory item transaction type list request in the Midnight SOAP API.
/// </summary>
[XmlRoot("Result")]
public class InventoryItemTransactionTypeListResult : CommonResult
{
    /// <summary>
    /// Gets or sets the list of item transaction types returned by the request.
    /// </summary>
    [XmlArray("ItemTransactionTypes")]
    [XmlArrayItem("ItemTransactionType")]
    public List<ItemTransactionType> ItemTransactionTypes { get; set; } = new List<ItemTransactionType>();
}

/// <summary>
/// Represents an item transaction type in the Midnight SOAP API.
/// </summary>
public class ItemTransactionType
{
    /// <summary>Gets or sets the item transaction type ID.</summary>
    public int? ItemTransactionTypeID { get; set; }
    /// <summary>Gets or sets the description of the transaction type.</summary>
    public string? Description { get; set; }
}